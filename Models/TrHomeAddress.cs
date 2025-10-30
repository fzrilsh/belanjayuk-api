namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrHomeAddress")]
public class TrHomeAddress
{
    [Key]
    [StringLength(36)]
    public string IdHomeAddress { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Provinsi { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Kotkab { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Kecamatan { get; set; } = string.Empty;

    [Required]
    [StringLength(5)]
    public string KodePos { get; set; } = string.Empty;

    [StringLength(2000)]
    public string? HomeAddressDesc { get; set; }

    [Required]
    public bool isPrimaryAddress { get; set; }

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