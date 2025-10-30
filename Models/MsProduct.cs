namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MsProduct")]
public class MsProduct
{
    [Key]
    [StringLength(36)]
    public string IdProduct { get; set; } = String.Empty;

    [Required]
    [StringLength(200)]
    public string ProductName { get; set; } = String.Empty;

    [StringLength(2000)]
    public string? ProductDesc { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(5, 2)")] 
    public decimal DiscountProduct { get; set; } = 0; 

    [Required]
    public int Qty { get; set; } = 0;

    public DateTime DateIn { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserIn { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    [ForeignKey("Seller")]
    [StringLength(36)]
    public string? IdUserSeller { get; set; }
    public MsUserSeller? Seller { get; set; }

    [ForeignKey("Category")]
    [StringLength(36)]
    public string? IdCategory { get; set; }
    public LtCategory? Category { get; set; }

    public ICollection<TrProductImage> ProductImages { get; set; } = new List<TrProductImage>();

    public ICollection<TrBuyerCart> BuyerCarts { get; set; } = new List<TrBuyerCart>();

    public ICollection<TrBuyerTransactionDetail> TransactionDetails { get; set; } = new List<TrBuyerTransactionDetail>();
}