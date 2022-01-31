using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class BuyingRawSilver
    {
        [Key]
        public int SilverCode { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal RawSilverQuantity { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal NoSilverUnits { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal GramsPerUnit { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal SilverValue { get; set; }
        [Column("GST", TypeName = "numeric(10, 2)")]
        public decimal Gst { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal TotalAmount { get; set; }
        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }
        [Required]
        [StringLength(100)]
        public string SupplierPhoneNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateofPurchase { get; set; }
        [StringLength(100)]
        public string Mass { get; set; }
        [StringLength(100)]
        public string ImageName { get; set; }
        [StringLength(100)]
        public string ImageName2 { get; set; }
        [StringLength(100)]
        public string ImageName3 { get; set; }
        [StringLength(100)]
        public string ImageName4 { get; set; }
        [StringLength(100)]
        public string ImageName5 { get; set; }
        [Column("IPADDRESS")]
        [StringLength(100)]
        public string Ipaddress { get; set; }
        [Column("PCNAME")]
        [StringLength(100)]
        public string Pcname { get; set; }
    }
}
