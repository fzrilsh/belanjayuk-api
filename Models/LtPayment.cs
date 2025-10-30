namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LtPayment")]
public class LtPayment
{
    [Key]
    [StringLength(36)]
    public string IdPayment { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string PaymentName { get; set; } = string.Empty;
   
    public DateTime Datein { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? Userin { get; set; }

    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    public ICollection<TrBuyerTransaction> BuyerTransactions { get; set; } = new List<TrBuyerTransaction>();
}