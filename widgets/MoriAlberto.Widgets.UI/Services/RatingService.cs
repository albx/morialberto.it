using MoriAlberto.Widgets.Models;
using System.Net.Http.Json;

namespace MoriAlberto.Widgets.UI.Services;

public class RatingService : IRatingService
{
    public HttpClient Client { get; }

    public RatingService(HttpClient client)
    {
        Client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public async Task<bool> LikePostAsync(string postUrl)
    {
        var model = new RatePostModel { Action = RatePostModel.RateAction.Like, PostUrl = postUrl };
        var response = await Client.PostAsJsonAsync("api/rate", model);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DislikePostAsync(string postUrl)
    {
        var model = new RatePostModel { Action = RatePostModel.RateAction.Dislike, PostUrl = postUrl };
        var response = await Client.PostAsJsonAsync("api/rate", model);

        return response.IsSuccessStatusCode;
    }

    public async Task<PostRatingsModel> GetPostRatingsAsync(string postUrl)
    {
        var model = await Client.GetFromJsonAsync<PostRatingsModel>($"api/ratings?post={System.Web.HttpUtility.UrlEncode(postUrl)}");
        return model ?? new PostRatingsModel(0, 0);
    }
}
