namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrBuyerTransaction")]
public class TrBuyerTransaction
{
    [Key]
    [StringLength(36)]
    public string IdBuyerTransaction { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal FinalPrice { get; set; }

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

    [ForeignKey("User")]
    [StringLength(36)]
    public string? IdUser { get; set; }
    public MsUser? User { get; set; }

   
    [ForeignKey("Payment")]
    [StringLength(36)]
    public string? IdPayment { get; set; }
    public LtPayment? Payment { get; set; }

    public ICollection<TrBuyerTransactionDetail> TransactionDetails { get; set; } = new List<TrBuyerTransactionDetail>();
}