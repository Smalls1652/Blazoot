using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

public class Account : IAccount
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("username")]
    public string UserName { get; set; }

    [JsonPropertyName("acct")]
    public string AccountUri { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    [JsonPropertyName("bot")]
    public bool Bot { get; set; }

    [JsonPropertyName("group")]
    public bool Group { get; set; }

    [JsonPropertyName("discoverable")]
    public bool Discoverable { get; set; }

    [JsonPropertyName("noindex")]
    public bool NoIndex { get; set; }

    [JsonPropertyName("moved")]
    public bool Moved { get; set; }

    [JsonPropertyName("suspended")]
    public bool Suspended { get; set; }

    [JsonPropertyName("limited")]
    public bool Limited { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("url")]
    public string URL { get; set; }

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    [JsonPropertyName("avatar_static")]
    public string AvatarStatic { get; set; }

    [JsonPropertyName("header")]
    public string Header { get; set; }

    [JsonPropertyName("header_static")]
    public string HeaderStatic { get; set; }

    [JsonPropertyName("followers_count")]
    public int FollowersCount { get; set; }

    [JsonPropertyName("following_count")]
    public int FollowingCount { get; set; }

    [JsonPropertyName("statuses_count")]
    public int StatusesCount { get; set; }

    [JsonPropertyName("last_status_at")]
    public DateTimeOffset? LastStatusAt { get; set; }

    [JsonPropertyName("emojis")]
    public IEnumerable<CustomEmoji> Emojis { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<AccountFieldItem> Fields { get; set; }
}