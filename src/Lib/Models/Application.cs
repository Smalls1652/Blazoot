using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

/// <summary>
/// Represents an application that interfaces with the REST API to access accounts or post statuses.
/// </summary>
public class Application : IApplication
{
    public Application()
    {}

    /// <inheritdoc />
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <inheritdoc />
    [JsonPropertyName("website")]
    public string? Website { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("vapid_key")]
    public string VapidKey { get; set; } = null!;

    /// <inheritdoc />
    [JsonPropertyName("client_id")]
    public string? ClientId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; set; }
}