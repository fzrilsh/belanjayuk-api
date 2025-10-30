namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrBuyerTransactionDetail")]
public class TrBuyerTransactionDetail
{
    [Key]
    [StringLength(36)]
    public string IdBuyerTransactionDetail { get; set; } = string.Empty;

    [Required]
    public int Qty { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PriceProduct { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal DiscountProduct { get; set; }

    public int? Rating { get; set; }

    [StringLength(1000)]
    public string? RatingComment { get; set; }

   
    public DateTime Datein { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? Userin { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations
   
    [ForeignKey("BuyerTransaction")]
    [StringLength(36)]
    public string? IdBuyerTransaction { get; set; }
    public TrBuyerTransaction? BuyerTransaction { get; set; }

   
    [ForeignKey("Product")]
    [StringLength(36)]
    public string? IdProduct { get; set; }
    public MsProduct? Product { get; set; }
}