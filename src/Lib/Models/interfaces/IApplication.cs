namespace Blazoot.Lib.Models;

public interface IApplication
{
    string Name { get; set; }
    string? Website { get; set; }
    string VapidKey { get; set; }
    string? ClientId { get; set; }
    string? ClientSecret { get; set; }
}