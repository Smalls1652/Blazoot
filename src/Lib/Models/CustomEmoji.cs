using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

/// <summary>
/// Represents a custom emoji on a Mastodon instance.
/// </summary>
public class CustomEmoji : ICustomEmoji
{
    /// <inheritdoc />
    [JsonPropertyName("shortcode")]
    public string Shortcode { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("static_url")]
    public string StaticUrl { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("visible_in_picker")]
    public bool VisibleInPicker { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("category")]
    public string Category { get; set; }
}