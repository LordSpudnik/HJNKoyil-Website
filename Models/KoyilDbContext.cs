using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace HJNKoyil.Models
{
    public partial class KoyilDbContext : IdentityDbContext //DbContext
    {
        public KoyilDbContext()
        {
        }

        public KoyilDbContext(DbContextOptions<KoyilDbContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

        public virtual DbSet<CommonMaster> CommonMaster { get; set; }

        public virtual DbSet<CommonMasterDtl> CommonMasterDtl { get; set; }

        public virtual DbSet<Donation> Donation { get; set; }

        public virtual DbSet<Expense> Expense { get; set; }

        public virtual DbSet<Individual> Individual { get; set; }

        public virtual DbSet<VwCommonMasterDtl> VwCommonMasterDtl { get; set; }

        public virtual DbSet<VwDonation> VwDonation { get; set; }

        public virtual DbSet<VwExpense> VwExpense { get; set; }
        
        public virtual DbSet<vwAppUsers> VwAppUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-HJNKoyil-45a241ea-ba8c-4909-99ab-d9d394944ed7;Trusted_Connection=True;MultipleActiveResultSets=true");

        //        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Entity<AspNetRole>(entity =>
        //            {
        //                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
        //                    .IsUnique()
        //                    .HasFilter("([NormalizedName] IS NOT NULL)");

        //                entity.Property(e => e.Name).HasMaxLength(256);
        //                entity.Property(e => e.NormalizedName).HasMaxLength(256);
        //            });

        //            modelBuilder.Entity<AspNetRoleClaim>(entity =>
        //            {
        //                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

        //                entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        //            });

        //            modelBuilder.Entity<AspNetUser>(entity =>
        //            {
        //                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

        //                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
        //                    .IsUnique()
        //                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

        //                entity.Property(e => e.Email).HasMaxLength(256);
        //                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
        //                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
        //                entity.Property(e => e.UserName).HasMaxLength(256);

        //                entity.HasMany(d => d.Roles).WithMany(p => p.Users)
        //                    .UsingEntity<Dictionary<string, object>>(
        //                        "AspNetUserRole",
        //                        r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
        //                        l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
        //                        j =>
        //                        {
        //                            j.HasKey("UserId", "RoleId");
        //                            j.ToTable("AspNetUserRoles");
        //                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
        //                        });
        //            });

        //            modelBuilder.Entity<AspNetUserClaim>(entity =>
        //            {
        //                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

        //                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        //            });

        //            modelBuilder.Entity<AspNetUserLogin>(entity =>
        //            {
        //                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

        //                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

        //                entity.Property(e => e.LoginProvider).HasMaxLength(128);
        //                entity.Property(e => e.ProviderKey).HasMaxLength(128);

        //                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        //            });

        //            modelBuilder.Entity<AspNetUserToken>(entity =>
        //            {
        //                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

        //                entity.Property(e => e.LoginProvider).HasMaxLength(128);
        //                entity.Property(e => e.Name).HasMaxLength(128);

        //                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        //            });

        //            modelBuilder.Entity<CommonMaster>(entity =>
        //            {
        //                entity.HasKey(e => e.Id).HasName("Common Master$PrimaryKey");

        //                entity.ToTable("CommonMaster");

        //                entity.Property(e => e.CommonText)
        //                    .HasMaxLength(255)
        //                    .HasColumnName("CommonMaster");
        //                entity.Property(e => e.CreatedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.IsActive).HasDefaultValue(true);
        //                entity.Property(e => e.ModifiedBy).HasDefaultValue(0);
        //                entity.Property(e => e.ModifiedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //            });

        //            modelBuilder.Entity<CommonMasterDtl>(entity =>
        //            {
        //                entity.HasKey(e => e.Id).HasName("Common Master Dtl$PrimaryKey");

        //                entity.ToTable("CommonMasterDtl");

        //                entity.Property(e => e.CommonItem).HasMaxLength(255);
        //                entity.Property(e => e.CommonMasterId).HasDefaultValue(0);
        //                entity.Property(e => e.CreatedBy).HasDefaultValue(0);
        //                entity.Property(e => e.CreatedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.IsActive).HasDefaultValue(true);
        //                entity.Property(e => e.ModifiedBy).HasDefaultValue(0);
        //                entity.Property(e => e.ModifiedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //            });

        //            modelBuilder.Entity<Donation>(entity =>
        //            {
        //                entity.HasKey(e => e.Id).HasName("Donations$PrimaryKey");

        //                entity.ToTable("Donation");

        //                entity.Property(e => e.AmountDonated).HasColumnType("money");
        //                entity.Property(e => e.CollectedBy).HasDefaultValue(0);
        //                entity.Property(e => e.Comments).HasMaxLength(255);
        //                entity.Property(e => e.CreatedBy).HasDefaultValue(0);
        //                entity.Property(e => e.CreatedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.DonatedBy).HasDefaultValue(0);
        //                entity.Property(e => e.DonatedDate).HasPrecision(0);
        //                entity.Property(e => e.DonationType).HasDefaultValue(0);
        //                entity.Property(e => e.IsActive).HasDefaultValue(false);
        //                entity.Property(e => e.ModifiedBy).HasDefaultValue(0);
        //                entity.Property(e => e.ModifiedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.ReferenceInfo).HasMaxLength(255);

        //                entity.HasOne(d => d.DonationTypeNavigation).WithMany(p => p.Donations)
        //                    .HasForeignKey(d => d.DonationType)
        //                    .HasConstraintName("Donations$CommonMasterDtlDonations");
        //            });

        //            modelBuilder.Entity<Expense>(entity =>
        //            {
        //                entity.HasKey(e => e.Id).HasName("Expenses$PrimaryKey");

        //                entity.ToTable("Expense");

        //                entity.Property(e => e.Amount)
        //                    .HasDefaultValue(0m)
        //                    .HasColumnType("money");
        //                entity.Property(e => e.Comments).HasMaxLength(255);
        //                entity.Property(e => e.CreatedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.ExpenseDate)
        //                    .HasDefaultValueSql("(getdate())")
        //                    .HasColumnType("datetime");
        //                entity.Property(e => e.ExpenseType).HasDefaultValue(0);
        //                entity.Property(e => e.IsActive).HasDefaultValue(false);
        //                entity.Property(e => e.ModifiedBy).HasDefaultValue(0);
        //                entity.Property(e => e.ModifiedDate)
        //                    .HasPrecision(0)
        //                    .HasDefaultValueSql("(getdate())");
        //                entity.Property(e => e.ServiceProviderId).HasDefaultValue(0);

        //                entity.HasOne(d => d.ExpenseTypeNavigation).WithMany(p => p.Expenses)
        //                    .HasForeignKey(d => d.ExpenseType)
        //                    .HasConstraintName("Expenses$CommonMasterDtlExpenses");
        //            });

        //            modelBuilder.Entity<Individual>(entity =>
        //            {
        //                entity.HasKey(e => e.Id).HasName("Individual$PrimaryKey");

        //                entity.ToTable("Individual");

        //                entity.Property(e => e.Id).HasColumnName("ID");
        //                entity.Property(e => e.Address1).HasMaxLength(255);
        //                entity.Property(e => e.Address2).HasMaxLength(255);
        //                entity.Property(e => e.Address3).HasMaxLength(255);
        //                entity.Property(e => e.AspnetUserName)
        //                    .HasMaxLength(50)
        //                    .HasColumnName("ASPNetUserName");
        //                entity.Property(e => e.City).HasMaxLength(255);
        //                entity.Property(e => e.FullName).HasMaxLength(255);
        //                entity.Property(e => e.MobileNumber).HasMaxLength(255);
        //                entity.Property(e => e.PinCode).HasMaxLength(255);
        //                entity.Property(e => e.State).HasMaxLength(255);
        //            });

        //            modelBuilder.Entity<VwCommonMasterDtl>(entity =>
        //            {
        //                entity
        //                    .HasNoKey()
        //                    .ToView("vwCommonMasterDtl");

        //                entity.Property(e => e.CommonItem).HasMaxLength(255);
        //                entity.Property(e => e.CommonMaster).HasMaxLength(255);
        //                entity.Property(e => e.ModifiedDate).HasPrecision(0);
        //            });

        //            modelBuilder.Entity<VwDonation>(entity =>
        //            {
        //                entity
        //                    .HasNoKey()
        //                    .ToView("vwDonation");

        //                entity.Property(e => e.AmountDonated).HasColumnType("money");
        //                entity.Property(e => e.CollectedByName).HasMaxLength(255);
        //                entity.Property(e => e.Comments).HasMaxLength(255);
        //                entity.Property(e => e.CreatedDate).HasPrecision(0);
        //                entity.Property(e => e.DonatedDate).HasPrecision(0);
        //                entity.Property(e => e.DonationTypeDesc).HasMaxLength(255);
        //                entity.Property(e => e.ModifiedDate).HasPrecision(0);
        //                entity.Property(e => e.ReferenceInfo).HasMaxLength(255);
        //                entity.Property(e => e.ServiceProvider).HasMaxLength(255);
        //            });

        //            modelBuilder.Entity<VwExpense>(entity =>
        //            {
        //                entity
        //                    .HasNoKey()
        //                    .ToView("vwExpense");

        //                entity.Property(e => e.Amount).HasColumnType("money");
        //                entity.Property(e => e.Comments).HasMaxLength(255);
        //                entity.Property(e => e.CreatedDate).HasPrecision(0);
        //                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");
        //                entity.Property(e => e.ExpenseTypeDesc).HasMaxLength(255);
        //                entity.Property(e => e.ModifiedDate).HasPrecision(0);
        //                entity.Property(e => e.PaidByName).HasMaxLength(255);
        //                entity.Property(e => e.ServiceProvider).HasMaxLength(255);
        //            });

        //            OnModelCreatingPartial(modelBuilder);
        //        }

        //        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
