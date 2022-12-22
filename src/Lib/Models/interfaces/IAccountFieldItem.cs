namespace Blazoot.Lib.Models;

public interface IAccountFieldItem
{
    string Name { get; set; }
    string Value { get; set; }
    DateTimeOffset? VerifiedAt { get; set; }
}