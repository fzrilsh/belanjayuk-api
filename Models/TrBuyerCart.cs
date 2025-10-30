namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrBuyerCart")]
public class TrBuyerCart
{
    [Key]
    [StringLength(36)]
    public string IdBuyerCart { get; set; } = string.Empty;

    [Required]
    public int Qty { get; set; }

    public DateTime Datein { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? Userin { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    [ForeignKey("User")]
    [StringLength(36)]
    public string? IdUser { get; set; }
    public MsUser? User { get; set; }

    [ForeignKey("Product")]
    [StringLength(36)]
    public string? IdProduct { get; set; }
    public MsProduct? Product { get; set; }
}