namespace Blazoot.Lib.Models;

/// <summary>
/// Interface for a Mastodon account.
/// </summary>
public interface IAccount
{
     /// <summary>
     /// A unique identifier for the account.
     /// </summary>
     string Id { get; set; }

     /// <summary>
     /// The username of the account, not including the domain.
     /// </summary>
     string UserName { get; set; }

     /// <summary>
     /// The Webfinger account URI. Equal to username for local users, or username@domain for remote users.
     /// </summary>
     string AccountUri { get; set; }

     /// <summary>
     /// The display name of the account.
     /// </summary>
     string DisplayName { get; set; }

     /// <summary>
     /// Whether the account requires approval of follow requests.
     /// </summary>
     bool Locked { get; set; }

     /// <summary>
     /// Whether the account is a bot.
     /// </summary>
     bool Bot { get; set; }

     /// <summary>
     /// Whether the account represents a "Group" actor.
     /// </summary>
     bool Group { get; set; }

     /// <summary>
     /// Whether the account has opted into discovery features.
     /// </summary>
     bool Discoverable { get; set; }

     /// <summary>
     /// Whether the account has opted out of being indexed by search engines.
     /// </summary>
     bool NoIndex { get; set; }

     /// <summary>
     /// Whether the account is currently inactive and has moved to another account.
     /// </summary>
     bool Moved { get; set; }

     /// <summary>
     /// Whether the account is suspended.
     /// </summary>
     bool Suspended { get; set; }

     /// <summary>
     /// Whether the account is limited.
     /// </summary>
     bool Limited { get; set; }

     /// <summary>
     /// The date and time when the account was created.
     /// </summary>
     DateTimeOffset CreatedAt { get; set; }

     /// <summary>
     /// The bio or description of the account.
     /// </summary>
     string Note { get; set; }

     /// <summary>
     /// The location of the user's profile page.
     /// </summary>
     string URL { get; set; }

     /// <summary>
     /// An image icon that is shown next to statuses and in profile.
     /// </summary>
     string Avatar { get; set; }

     /// <summary>
     /// A static version of the avatar.
     /// </summary>
     string AvatarStatic { get; set; }

     /// <summary>
     /// An image banner that is shown above the profile and in profile cards.
     /// </summary>
     string Header { get; set; }

     /// <summary>
     /// A static version of the header.
     /// </summary>
     string HeaderStatic { get; set; }

     /// <summary>
     /// The amount of followers the account has.
     /// </summary>
     int FollowersCount { get; set; }

     /// <summary>
     /// The amount of accounts the account is following.
     /// </summary>
     int FollowingCount { get; set; }

     /// <summary>
     /// The amount of statuses the account has posted.
     /// </summary>
     int StatusesCount { get; set; }

     /// <summary>
     /// The date and time when the most recent status was posted, if available.
     /// </summary>
     DateTimeOffset? LastStatusAt { get; set; }

     /// <summary>
     /// A collection of <see cref="CustomEmoji" /> items to be used when rendering the profile.
     /// </summary>
     IEnumerable<CustomEmoji> Emojis { get; set; }

     /// <summary>
     /// A collection of <see cref="AccountFieldItem" /> items attached to the profile.
     /// </summary>
     IEnumerable<AccountFieldItem> Fields { get; set; }
}