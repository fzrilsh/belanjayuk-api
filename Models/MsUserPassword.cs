namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MsUserPassword")]
public class MsUserPassword
{
    [Key]
    [StringLength(36)]
    public string IdUserPassword { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string? PasswordHash { get; set; }

    public DateTime DateIn { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserIn { get; set; }

    [Required]
    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    [ForeignKey("User")]
    [StringLength(36)]
    public string? IdUser { get; set; }
    public MsUser? User { get; set; }
}