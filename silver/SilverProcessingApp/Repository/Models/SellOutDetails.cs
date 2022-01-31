using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class SellOutDetails
    {
        [Key]
        public int SelloutId { get; set; }
        [Required]
        [StringLength(100)]
        public string BillNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Soldby { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerPhoneNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime Selloutdate { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal Selloutvalue { get; set; }
    }
}
