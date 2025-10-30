namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrProductimages")]
public class TrProductImage
{
    [Key]
    [StringLength(36)]
    public string IdProductimages { get; set; } = string.Empty;

    public string Productimage { get; set; } = string.Empty;

    public DateTime Datein { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? Userin { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    [ForeignKey("Product")]
    [StringLength(36)]
    public string? IdProduct { get; set; }
    public MsProduct? Product { get; set; }
}