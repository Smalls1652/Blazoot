namespace Blazoot.Lib.Models;

public interface IPreviewCard
{
    string? Url { get; set; }
    string? Title { get; set; }
    string? Description { get; set; }
    string? Type { get; set; }
    string? AuthorName { get; set; }
    string? AuthorUrl { get; set; }
    string? ProviderName { get; set; }
    string? ProviderUrl { get; set; }
    string? Html { get; set; }
    int Width { get; set; }
    int Height { get; set; }
    string? Image { get; set; }
    string? EmbedUrl { get; set; }
    string? BlurHash { get; set; }
}