namespace Blazoot.Lib.Models;

public interface IAccount
{
     string Id { get; set; }
     string UserName { get; set; }
     string AccountUri { get; set; }
     string DisplayName { get; set; }
     bool Locked { get; set; }
     bool Bot { get; set; }
     bool Group { get; set; }
     bool Discoverable { get; set; }
     bool NoIndex { get; set; }
     bool Moved { get; set; }
     bool Suspended { get; set; }
     bool Limited { get; set; }
     DateTimeOffset CreatedAt { get; set; }
     string Note { get; set; }
     string URL { get; set; }
     string Avatar { get; set; }
     string AvatarStatic { get; set; }
     string Header { get; set; }
     string HeaderStatic { get; set; }
     int FollowersCount { get; set; }
     int FollowingCount { get; set; }
     int StatusesCount { get; set; }
     DateTimeOffset? LastStatusAt { get; set; }
     IEnumerable<CustomEmoji> Emojis { get; set; }
     IEnumerable<AccountFieldItem> Fields { get; set; }
}