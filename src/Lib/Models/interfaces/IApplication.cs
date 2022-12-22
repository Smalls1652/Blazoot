namespace Blazoot.Lib.Models;

/// <summary>
/// Interface for a Mastodon application.
/// </summary>
public interface IApplication
{
    /// <summary>
    /// The name of the application.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The website associated with the application.
    /// </summary>
    string? Website { get; set; }

    /// <summary>
    /// Used for the push streaming API.
    /// </summary>
    string VapidKey { get; set; }

    /// <summary>
    /// Unique identifier for the application.
    /// </summary>
    string? ClientId { get; set; }

    /// <summary>
    /// Secret key to be used for obtaining an access token.
    /// </summary>
    string? ClientSecret { get; set; }
}