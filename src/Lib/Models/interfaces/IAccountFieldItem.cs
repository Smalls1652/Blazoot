namespace Blazoot.Lib.Models;


/// <summary>
/// Interface for a Mastodon account's field item.
/// </summary>
public interface IAccountFieldItem
{
    /// <summary>
    /// Name of the field.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The value of the field.
    /// </summary>
    string Value { get; set; }

    /// <summary>
    /// Timestamp of when the server verified a URL value for a rel=“me” link.
    /// </summary>
    DateTimeOffset? VerifiedAt { get; set; }
}