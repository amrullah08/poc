using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class SilverContext : DbContext
    {
        public SilverContext(DbContextOptions<SilverContext> options) : base(options)
        {
        }
        public DbSet<BuyingRawSilver> BuyingRawSilver { get; set; }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        public DbSet<SupplierDetails> SupplierDetails { get; set; }

        public DbSet<SilverArticles> SilverArticles { get; set; }

        public DbSet<SellOutDetails> SellOutDetails { get; set; }
        public virtual DbSet<ScrapSilverPurityCalculatorJobDetails> ScrapSilverPurityCalculatorJobDetails { get; set; }

        public virtual DbSet<ScrapSilverPurityConvertorJob> ScrapSilverPurityConvertorJob { get; set; }



        //public virtual DbSet<PurityCalculator> PurityCalculator { get; set; }

        //public  DbSet<PurityConvertor> PurityConvertor { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PurityCalculator>().HasNoKey();
        //}
    }
}
