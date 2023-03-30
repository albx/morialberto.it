using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using MoriAlberto.Widgets.Api.Services;
using MoriAlberto.Widgets.Models;
using System.Net;

namespace MoriAlberto.Widgets.Api;

public class RatingFunction
{
    private readonly ILogger _logger;

    public RateService Service { get; }

    public RatingFunction(ILoggerFactory loggerFactory, RateService service)
    {
        _logger = loggerFactory.CreateLogger<RatingFunction>();
        Service = service ?? throw new ArgumentNullException(nameof(service));
    }

    [Function(nameof(RatePost))]
    public async Task<HttpResponseData> RatePost(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "rate")] HttpRequestData req)
    {
        var model = await req.ReadFromJsonAsync<RatePostModel>();
        if (model is null)
        {
            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        _logger.LogInformation("Rate post {PostUrl}: {RateAction}", model.PostUrl, model.Action);

        try
        {
            await Service.RatePostAsync(model);

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error rating post {PostUrl}: {ErrorMessage}", model.PostUrl, ex.Message);
            return req.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }

    [Function(nameof(GetPostRatings))]
    public async Task<HttpResponseData> GetPostRatings(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "ratings")] HttpRequestData req)
    {
        var query = QueryHelpers.ParseQuery(req.Url.Query);
        var postUrl = query["post"].ToString();

        var ratings = await Service.GetPostRatingsAsync(postUrl);

        var response = req.CreateResponse();
        await response.WriteAsJsonAsync(ratings);

        return response;
    }
}
