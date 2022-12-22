using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

public class AccountFieldItem : IAccountFieldItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("verified_at")]
    public DateTimeOffset? VerifiedAt { get; set; }
}