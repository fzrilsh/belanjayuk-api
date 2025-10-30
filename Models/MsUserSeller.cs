namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MsUserSeller")]
public class MsUserSeller
{
    [Key]
    [StringLength(36)]
    public string IdUserSeller { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string SellerName { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? SellerDesc { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    [Required]
    [StringLength(100)]
    public string SellerCode { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string PhoneNumber { get; set; } = string.Empty;

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

    public ICollection<MsProduct> Products { get; set; } = new List<MsProduct>();
}