namespace Blazoot.Lib.Models;

public interface ICustomEmoji
{
    string Shortcode { get; set; }
    string Url { get; set; }
    string StaticUrl { get; set; }
    bool VisibleInPicker { get; set; }
    string Category { get; set; }
}