namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LtGender")]
public class LtGender
{
    [Key]
    [StringLength(36)]
    public string IdGender { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string GenderName { get; set; } = string.Empty;

    public DateTime DateIn { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserIn { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relation
    
    public ICollection<MsUser> Users { get; set; } = new List<MsUser>();
}