using MoriAlberto.Widgets.Models;

namespace MoriAlberto.Widgets.UI.Services;

public interface IRatingService
{
    Task<bool> LikePostAsync(string postUrl);

    Task<bool> DislikePostAsync(string postUrl);

    Task<PostRatingsModel> GetPostRatingsAsync(string postUrl);
}
