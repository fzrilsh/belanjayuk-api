using Microsoft.EntityFrameworkCore;
using BelanjaYuk.API.Models;

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
        public DbSet<TrProductImage> TrProductImages { get; set; }
        public DbSet<TrBuyerCart> TrBuyerCarts { get; set; }
        public DbSet<LtPayment> LtPayments { get; set; }
        public DbSet<TrBuyerTransaction> TrBuyerTransactions { get; set; }
        public DbSet<TrBuyerTransactionDetail> TrBuyerTransactionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Relation one-to-one
            modelBuilder.Entity<MsUser>()
                .HasOne(user => user.SellerInfo)
                .WithOne(seller => seller.User)
                .HasForeignKey<MsUserSeller>(seller => seller.IdUser);

            // Relation one-to-Many
            modelBuilder.Entity<MsUserSeller>()
                .HasMany(seller => seller.Products)
                .WithOne(product => product.Seller)
                .HasForeignKey(product => product.IdUserSeller);

            // Relation one-to-Many
            modelBuilder.Entity<LtCategory>()
                .HasMany(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.IdCategory);

            // Relation one-to-Many
            modelBuilder.Entity<MsUser>()
                .HasMany(user => user.Passwords)
                .WithOne(pass => pass.User)
                .HasForeignKey(pass => pass.IdUser);

            // Relation one-to-Many
            modelBuilder.Entity<MsUser>()
                .HasMany(user => user.HomeAddresses)
                .WithOne(addr => addr.User)
                .HasForeignKey(addr => addr.IdUser);

            // Relation one-to-Many
            modelBuilder.Entity<MsUser>()
                .HasMany(user => user.BuyerCarts)
                .WithOne(cart => cart.User)
                .HasForeignKey(cart => cart.IdUser);

            // Relation one-to-Many
            modelBuilder.Entity<MsUser>()
                .HasMany(user => user.BuyerTransactions)
                .WithOne(trans => trans.User)
                .HasForeignKey(trans => trans.IdUser);

            // Relation one-to-Many
            modelBuilder.Entity<LtGender>()
                .HasMany(gender => gender.Users)
                .WithOne(user => user.Gender)
                .HasForeignKey(user => user.IdGender);

            // Relation one-to-Many
            modelBuilder.Entity<MsProduct>()
                .HasMany(prod => prod.ProductImages)
                .WithOne(img => img.Product)
                .HasForeignKey(img => img.IdProduct);

            // Relation one-to-Many
            modelBuilder.Entity<MsProduct>()
                .HasMany(prod => prod.BuyerCarts)
                .WithOne(cart => cart.Product)
                .HasForeignKey(cart => cart.IdProduct);

            // Relation one-to-Many
            modelBuilder.Entity<MsProduct>()
                .HasMany(prod => prod.TransactionDetails)
                .WithOne(detail => detail.Product)
                .HasForeignKey(detail => detail.IdProduct);

            // Relation one-to-Many
            modelBuilder.Entity<LtPayment>()
                .HasMany(pay => pay.BuyerTransactions)
                .WithOne(trans => trans.Payment)
                .HasForeignKey(trans => trans.IdPayment);

            // Relation one-to-Many
            modelBuilder.Entity<TrBuyerTransaction>()
                .HasMany(trans => trans.TransactionDetails)
                .WithOne(detail => detail.BuyerTransaction)
                .HasForeignKey(detail => detail.IdBuyerTransaction);
        }
    }
}