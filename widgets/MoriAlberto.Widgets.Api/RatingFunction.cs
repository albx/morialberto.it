using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using MoriAlberto.Widgets.Api.Services;
using MoriAlberto.Widgets.Models;
using System.Net;

namespace MoriAlberto.Widgets.Api
{
    public class RatingFunction
    {
        private readonly ILogger _logger;

        public RateService Service { get; }

        public RatingFunction(ILoggerFactory loggerFactory, RateService service)
        {
            _logger = loggerFactory.CreateLogger<RatingFunction>();
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [Function("Rating")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var model = await req.ReadFromJsonAsync<PostRating>();
            if (model is null)
            {
                return req.CreateResponse(HttpStatusCode.BadRequest);
            }

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
    }
}
