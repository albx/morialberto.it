using System.ComponentModel.DataAnnotations;

namespace MoriAlberto.Widgets.Models;

public record RatePostModel
{
    [Required]
    public string PostUrl { get; init; } = string.Empty;

    [Required]
    public RateAction Action { get; init; }

    public enum RateAction
    {
        Like,
        Dislike
    }
}
