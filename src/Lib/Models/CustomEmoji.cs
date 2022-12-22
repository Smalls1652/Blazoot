using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

public class CustomEmoji : ICustomEmoji
{
    [JsonPropertyName("shortcode")]
    public string Shortcode { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("static_url")]
    public string StaticUrl { get; set; }

    [JsonPropertyName("visible_in_picker")]
    public bool VisibleInPicker { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }
}