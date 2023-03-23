using Azure.Data.Tables;
using Microsoft.Extensions.Options;
using MoriAlberto.Widgets.Api.Configuration;
using MoriAlberto.Widgets.Models;

namespace MoriAlberto.Widgets.Api.Services;

public class RateService
{
    private readonly TableClient _tableClient;

    private readonly StorageConfigurationOptions _storageConfiguration;

    public RateService(IOptions<StorageConfigurationOptions> storageConfigurationOptions)
    {
        _storageConfiguration = storageConfigurationOptions?.Value ?? throw new ArgumentNullException(nameof(storageConfigurationOptions));

        _tableClient = new TableClient(_storageConfiguration.ConnectionString, "Ratings");
        _tableClient.CreateIfNotExists();
    }

    public async Task RatePostAsync(RatePostModel model)
    {
        try
        {
            var rate = _tableClient.Query<TableEntity>(e => e.RowKey == model.PostUrl).FirstOrDefault();
            if (rate is null)
            {
                rate = new TableEntity(model.PostUrl, model.PostUrl)
                {
                    ["Like"] = 0,
                    ["Dislike"] = 0
                };
            }

            switch (model.Action)
            {
                case RatePostModel.RateAction.Like:
                    rate["Like"] = Convert.ToInt32(rate["Like"]) + 1;
                    break;
                case RatePostModel.RateAction.Dislike:
                    rate["Dislike"] = Convert.ToInt32(rate["Dislike"]) + 1;
                    break;
                default:
                    break;
            }

            await _tableClient.UpsertEntityAsync(rate);
        }
        catch
        {
            throw;
        }

    }

    public PostRatingsModel GetPostRatings(string postUrl)
    {
        try
        {
            var rate = _tableClient.Query<TableEntity>(e => e.RowKey == postUrl).FirstOrDefault();
            if (rate is null)
            {
                return new PostRatingsModel(0, 0);
            }

            return new PostRatingsModel(Convert.ToInt32(rate["Like"]), Convert.ToInt32(rate["Dislike"]));
        }
        catch
        {
            return new PostRatingsModel(0, 0);
        }

    }
}
