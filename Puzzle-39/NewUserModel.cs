using System.ComponentModel.DataAnnotations;

namespace Puzzle_39;

public class NewUserModel
{

    [Required]
    public string? UserName { get; set; } = string.Empty;

    [Required]
    public string? Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string? Email { get; set; } = string.Empty;

}
