using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

/// <summary>
/// Represents custom metadata for a Mastodon <see cref="Account" />.
/// </summary>
public class AccountFieldItem : IAccountFieldItem
{
    /// <inheritdoc />
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("verified_at")]
    public DateTimeOffset? VerifiedAt { get; set; }
}