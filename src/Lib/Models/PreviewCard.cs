using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

public class PreviewCard : IPreviewCard
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("author_name")]
    public string? AuthorName { get; set; }

    [JsonPropertyName("author_url")]
    public string? AuthorUrl { get; set; }

    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }

    [JsonPropertyName("provider_url")]
    public string? ProviderUrl { get; set; }

    [JsonPropertyName("html")]
    public string? Html { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("embed_url")]
    public string? EmbedUrl { get; set; }

    [JsonPropertyName("blurhash")]
    public string? BlurHash { get; set; }
}