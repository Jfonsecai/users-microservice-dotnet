using System.ComponentModel.DataAnnotations;

namespace UsersService.Application.DTOs;

public class UpdateUserDto
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;
}