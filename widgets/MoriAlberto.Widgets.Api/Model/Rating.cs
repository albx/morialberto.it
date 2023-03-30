namespace MoriAlberto.Widgets.Api.Model;

public class Rating
{
    public Guid Id { get; init; }

    public string Website { get; init; } = string.Empty;

    public string PageUrl { get; init; } = string.Empty;

    public int NumberOfLikes { get; init; }

    public int NumberOfDislikes { get; init; }
}
