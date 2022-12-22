using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

/// <summary>
/// Represents a rich preview card that is generated using OpenGraph tags from a URL.
/// </summary>
public class PreviewCard : IPreviewCard
{
    /// <inheritdoc />
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("author_name")]
    public string? AuthorName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("author_url")]
    public string? AuthorUrl { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("provider_url")]
    public string? ProviderUrl { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("html")]
    public string? Html { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("embed_url")]
    public string? EmbedUrl { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("blurhash")]
    public string? BlurHash { get; set; }
}