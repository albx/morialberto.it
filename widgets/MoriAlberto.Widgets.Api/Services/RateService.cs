using Dapper;
using Microsoft.Extensions.Options;
using MoriAlberto.Widgets.Api.Configuration;
using MoriAlberto.Widgets.Api.Model;
using MoriAlberto.Widgets.Models;
using System.Data.SqlClient;

namespace MoriAlberto.Widgets.Api.Services;

public class RateService
{
    private readonly KittConfigurationOptions _databaseConfiguration;

    public RateService(IOptions<KittConfigurationOptions> databaseConfigurationOptions)
    {
        _databaseConfiguration = databaseConfigurationOptions?.Value ?? throw new ArgumentNullException(nameof(databaseConfigurationOptions));
    }

    public async Task RatePostAsync(RatePostModel model)
    {
        try
        {
            using var connection = new SqlConnection(_databaseConfiguration.ConnectionString);
            connection.Open();

            var rating = await GetRatingByPageUrlAsync(model.PostUrl, connection);
            if (rating is null)
            {
                await AddRatingAsync(model, connection);
            }
            else
            {
                await UpdateRatingAsync(model, rating, connection);
            }
        }
        catch
        {
            throw;
        }
    }

    public async Task<PostRatingsModel> GetPostRatingsAsync(string postUrl)
    {
        try
        {
            using var connection = new SqlConnection(_databaseConfiguration.ConnectionString);
            connection.Open();

            var rating = await GetRatingByPageUrlAsync(postUrl, connection);
            if (rating is null)
            {
                return new PostRatingsModel(0, 0);
            }

            return new PostRatingsModel(rating.NumberOfLikes, rating.NumberOfDislikes);
        }
        catch
        {
            return new PostRatingsModel(0, 0);
        }
    }

    private async Task<Rating?> GetRatingByPageUrlAsync(string pageUrl, SqlConnection connection)
    {
        var sql = "SELECT Id, Website, PageUrl, NumberOfLikes, NumberOfDislikes FROM KITT_Ratings WHERE Website=@website AND PageUrl=@pageUrl";

        var rating = await connection.QueryFirstOrDefaultAsync<Rating>(
            sql,
            new { website = "morialberto.it", pageUrl = pageUrl });

        return rating;
    }

    private async Task AddRatingAsync(RatePostModel model, SqlConnection connection)
    {
        var rating = new Rating
        {
            Id = Guid.NewGuid(),
            PageUrl = model.PostUrl,
            Website = "morialberto.it",
            NumberOfLikes = model.Action == RatePostModel.RateAction.Like ? 1 : 0,
            NumberOfDislikes = model.Action == RatePostModel.RateAction.Dislike ? 1 : 0
        };

        var sql = "INSERT INTO KITT_Ratings(Id, Website, PageUrl, NumberOfLikes, NumberOfDislikes) VALUES(@Id, @Website, @PageUrl, @NumberOfLikes, @NumberOfDislikes)";
        await connection.ExecuteAsync(sql, rating);
    }

    private async Task UpdateRatingAsync(RatePostModel model, Rating rating, SqlConnection connection)
    {
        var id = rating.Id;
        var numberOfLikes = rating.NumberOfLikes;
        var numberOfDislikes = rating.NumberOfDislikes;

        switch (model.Action)
        {
            case RatePostModel.RateAction.Like:
                numberOfLikes++;
                break;
            case RatePostModel.RateAction.Dislike:
                numberOfDislikes++;
                break;
            default:
                break;
        }

        var sql = "UPDATE KITT_Ratings SET NumberOfLikes=@numberOfLikes, NumberOfDislikes=@numberOfDislikes WHERE Id=@id";
        await connection.ExecuteAsync(
            sql,
            new { numberOfLikes, numberOfDislikes, id });
    }
}
