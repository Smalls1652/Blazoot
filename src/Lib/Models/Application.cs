using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

public class Application : IApplication
{
    public Application()
    {}

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("vapid_key")]
    public string VapidKey { get; set; } = null!;

    [JsonPropertyName("client_id")]
    public string? ClientId { get; set; }

    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; set; }
}