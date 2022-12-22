namespace Blazoot.Lib.Models;

/// <summary>
/// Interface for a Mastodon Preview Card.
/// </summary>
public interface IPreviewCard
{
    /// <summary>
    /// Location of linked resource.
    /// </summary>
    string? Url { get; set; }

    /// <summary>
    /// Title of linked resource.
    /// </summary>
    string? Title { get; set; }

    /// <summary>
    /// Description of preview.
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// The type of the preview card.
    /// </summary>
    string? Type { get; set; }

    /// <summary>
    /// The author of the original resource.
    /// </summary>
    string? AuthorName { get; set; }

    /// <summary>
    /// A link to the author of the original resource.
    /// </summary>
    string? AuthorUrl { get; set; }

    /// <summary>
    /// The provider of the original resource.
    /// </summary>
    string? ProviderName { get; set; }

    /// <summary>
    /// A link to the provider of the original resource.
    /// </summary>
    string? ProviderUrl { get; set; }

    /// <summary>
    /// HTML to be used for generating the preview card.
    /// </summary>
    string? Html { get; set; }

    /// <summary>
    /// Width of preview, in pixels.
    /// </summary>
    int Width { get; set; }

    /// <summary>
    /// Height of preview, in pixels.
    /// </summary>
    int Height { get; set; }

    /// <summary>
    /// Preview thumbnail.
    /// </summary>
    string? Image { get; set; }

    /// <summary>
    /// A link used for photo embeds, instead of custom HTML.
    /// </summary>
    string? EmbedUrl { get; set; }

    /// <summary>
    /// A hash computed by <see href="https://github.com/woltapp/blurhash">the BlurHash algorithm</see>, for generating colorful preview thumbnails when media has not been downloaded yet.
    /// </summary>
    string? BlurHash { get; set; }
}