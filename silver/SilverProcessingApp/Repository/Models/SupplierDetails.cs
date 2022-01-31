using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class SupplierDetails
    {
        [Key]
        public int SupplierCode { get; set; }
        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }
        [Required]
        [StringLength(100)]
        public string SupplierPhoneNo { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal QuantityBuyed { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal AmountPayed { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal OutstandingAmount { get; set; }
    }
}
