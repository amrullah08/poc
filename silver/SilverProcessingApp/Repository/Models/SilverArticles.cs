using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class SilverArticles
    {
        [Key]
        public int SilverArticleId { get; set; }
        [Required]
        [StringLength(100)]
        public string TypeofSilverArticle { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateofProcess { get; set; }
        [Required]
        [StringLength(100)]
        public string Processby { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal RawSilverQuantity { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal NetWeight { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal SilverValue { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal MakingCharges { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal Wastage { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal Total { get; set; }
        [Column("GST", TypeName = "numeric(10, 2)")]
        public decimal Gst { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal TotalAmount { get; set; }
    }
}
