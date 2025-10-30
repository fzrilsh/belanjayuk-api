using Microsoft.EntityFrameworkCore;

namespace BelanjaYuk.API.Data
{
    public class BelanjaYukDbContext : DbContext
    {
        public BelanjaYukDbContext(DbContextOptions<BelanjaYukDbContext> options) : base(options)
        {
        }

        public DbSet<MsUser> MsUsers { get; set; }
        public DbSet<MsUserPassword> MsUserPasswords { get; set; }
        public DbSet<LtGender> LtGenders { get; set; }
        public DbSet<TrHomeAddress> TrHomeAddresses { get; set; }
        public DbSet<MsUserSeller> MsUserSellers { get; set; }
        public DbSet<MsProduct> MsProducts { get; set; }
        public DbSet<LtCategory> LtCategories { get; set; }
        public DbSet<TrProductImage> TrProductImages { get; set; } // ERD: TrProductimages
        public DbSet<TrBuyerCart> TrBuyerCarts { get; set; }
        public DbSet<LtPayment> LtPayments { get; set; }
        public DbSet<TrBuyerTransaction> TrBuyerTransactions { get; set; }
        public DbSet<TrBuyerTransactionDetail> TrBuyerTransactionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<MsUser>()
                .HasOne(user => user.SellerInfo)
                .WithOne(seller => seller.User)
                .HasForeignKey<MsUserSeller>(seller => seller.IdUser);

            modelBuilder.Entity<MsUserSeller>()
                .HasMany(seller => seller.Products)
                .WithOne(product => product.Seller)
                .HasForeignKey(product => product.IdUserSeller);

             modelBuilder.Entity<LtCategory>()
                .HasMany(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.IdCategory);
        }
    }

    public class MsUser {}
    public class MsUserPassword {}
    public class LtGender {}
    public class TrHomeAddress {}
    public class MsUserSeller { 
    }
    public class MsProduct { 
    }
    public class LtCategory { 
    }
    
    public class TrProductImage {}
    public class TrBuyerCart {}
    public class LtPayment {}
    public class TrBuyerTransaction {}
    public class TrBuyerTransactionDetail {}

}