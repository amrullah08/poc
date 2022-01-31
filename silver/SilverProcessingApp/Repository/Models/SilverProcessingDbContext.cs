using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class SilverProcessingDbContext : DbContext
    {
        public SilverProcessingDbContext()
        {
        }

        public SilverProcessingDbContext(DbContextOptions<SilverProcessingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BuyingRawSilver> BuyingRawSilver { get; set; }
        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public virtual DbSet<ScrapSilverPurityCalculatorJobDetails> ScrapSilverPurityCalculatorJobDetails { get; set; }
        public virtual DbSet<ScrapSilverPurityConvertorJob> ScrapSilverPurityConvertorJob { get; set; }
        public virtual DbSet<SellOutDetails> SellOutDetails { get; set; }
        public virtual DbSet<SilverArticles> SilverArticles { get; set; }
        public virtual DbSet<SupplierDetails> SupplierDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IUVOT87\\SQLEXPRESS;Database=SilverProcessingDb;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<BuyingRawSilver>(entity =>
            {
                entity.Property(e => e.Mass).IsUnicode(false);

                entity.Property(e => e.SupplierName).IsUnicode(false);

                entity.Property(e => e.SupplierPhoneNo).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeDetails>(entity =>
            {
                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.JobType).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapSilverPurityCalculatorJobDetails>(entity =>
            {
                entity.HasIndex(e => e.ScrapSilverPurityCalculatorJobDetailsSilverCode);

                entity.HasIndex(e => e.ScrapSilverPurityConvertorJobPid);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapSilverPurityConvertorJob>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FromBuyer).IsUnicode(false);

                entity.Property(e => e.ToEndUser).IsUnicode(false);
            });

            modelBuilder.Entity<SellOutDetails>(entity =>
            {
                entity.Property(e => e.BillNo).IsUnicode(false);

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.Property(e => e.CustomerPhoneNo).IsUnicode(false);

                entity.Property(e => e.Soldby).IsUnicode(false);
            });

            modelBuilder.Entity<SilverArticles>(entity =>
            {
                entity.Property(e => e.Processby).IsUnicode(false);

                entity.Property(e => e.TypeofSilverArticle).IsUnicode(false);
            });

            modelBuilder.Entity<SupplierDetails>(entity =>
            {
                entity.Property(e => e.SupplierName).IsUnicode(false);

                entity.Property(e => e.SupplierPhoneNo).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
