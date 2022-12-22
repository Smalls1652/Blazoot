namespace Blazoot.Lib.Models;

/// <summary>
/// Interface for a Mastodon custom emoji.
/// </summary>
public interface ICustomEmoji
{
    /// <summary>
    /// The name of the custom emoji.
    /// </summary>
    string Shortcode { get; set; }

    /// <summary>
    /// A link to the custom emoji.
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// A link to a static copy of the custom emoji.
    /// </summary>
    string StaticUrl { get; set; }

    /// <summary>
    /// Whether the custom emoji should be visible in the picker or unlisted.
    /// </summary>
    bool VisibleInPicker { get; set; }

    /// <summary>
    /// Used for sorting custom emoji in the picker.
    /// </summary>
    string Category { get; set; }
}