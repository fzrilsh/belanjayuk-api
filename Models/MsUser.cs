namespace BelanjaYuk.API.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MsUser")]
public class MsUser
{
    [Key]
    [StringLength(36)]
    public string IdUser { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Firstname { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "date")]
    public DateTime DOB { get; set; }

    public DateTime DateIn { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserIn { get; set; }

    [Required]
    public DateTime DateUp { get; set; } = DateTime.UtcNow;

    [StringLength(36)]
    public string? UserUp { get; set; }

    public bool IsActive { get; set; } = true;

    // Relations

    [ForeignKey("Gender")]
    [StringLength(36)]
    public string? IdGender { get; set; }
    public LtGender? Gender { get; set; }

    public MsUserSeller? SellerInfo { get; set; }

    public ICollection<MsUserPassword> Passwords { get; set; } = new List<MsUserPassword>();

    public ICollection<TrHomeAddress> HomeAddresses { get; set; } = new List<TrHomeAddress>();

    public ICollection<TrBuyerCart> BuyerCarts { get; set; } = new List<TrBuyerCart>();

    public ICollection<TrBuyerTransaction> BuyerTransactions { get; set; } = new List<TrBuyerTransaction>();
}