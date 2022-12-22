using System.Text.Json.Serialization;

namespace Blazoot.Lib.Models;

/// <summary>
/// Represents a user of Mastodon and their associated profile.
/// </summary>
public class Account : IAccount
{
    /// <inheritdoc />
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("username")]
    public string UserName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("acct")]
    public string AccountUri { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("bot")]
    public bool Bot { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("group")]
    public bool Group { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("discoverable")]
    public bool Discoverable { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("noindex")]
    public bool NoIndex { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("moved")]
    public bool Moved { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("suspended")]
    public bool Suspended { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("limited")]
    public bool Limited { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("note")]
    public string Note { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("url")]
    public string URL { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("avatar_static")]
    public string AvatarStatic { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("header")]
    public string Header { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("header_static")]
    public string HeaderStatic { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("followers_count")]
    public int FollowersCount { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("following_count")]
    public int FollowingCount { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("statuses_count")]
    public int StatusesCount { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("last_status_at")]
    public DateTimeOffset? LastStatusAt { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("emojis")]
    public IEnumerable<CustomEmoji> Emojis { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("fields")]
    public IEnumerable<AccountFieldItem> Fields { get; set; }
}