using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class ScrapSilverPurityCalculatorJobDetails
    {
        public ScrapSilverPurityCalculatorJobDetails()
        {
            InverseScrapSilverPurityCalculatorJobDetailsSilverCodeNavigation = new HashSet<ScrapSilverPurityCalculatorJobDetails>();
        }

        [Key]
        public int SilverCode { get; set; }
        public int ProductNumber { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal QuantityinGms { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal PercentageTomakepure { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal PureSilver { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal ExpectedfinalPurity { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal FinalPurity { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal FinalValue { get; set; }
        public int Pido { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column("IPADDRESS")]
        [StringLength(100)]
        public string Ipaddress { get; set; }
        [Column("PCNAME")]
        [StringLength(100)]
        public string Pcname { get; set; }
        [StringLength(100)]
        public string UserId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastModified { get; set; }
        public int? ScrapSilverPurityCalculatorJobDetailsSilverCode { get; set; }
        public int? ScrapSilverPurityConvertorJobPid { get; set; }

        [ForeignKey(nameof(ScrapSilverPurityCalculatorJobDetailsSilverCode))]
        [InverseProperty(nameof(ScrapSilverPurityCalculatorJobDetails.InverseScrapSilverPurityCalculatorJobDetailsSilverCodeNavigation))]
        public virtual ScrapSilverPurityCalculatorJobDetails ScrapSilverPurityCalculatorJobDetailsSilverCodeNavigation { get; set; }
        [ForeignKey(nameof(ScrapSilverPurityConvertorJobPid))]
        [InverseProperty(nameof(ScrapSilverPurityConvertorJob.ScrapSilverPurityCalculatorJobDetails))]
        public virtual ScrapSilverPurityConvertorJob ScrapSilverPurityConvertorJobP { get; set; }
        [InverseProperty(nameof(ScrapSilverPurityCalculatorJobDetails.ScrapSilverPurityCalculatorJobDetailsSilverCodeNavigation))]
        public virtual ICollection<ScrapSilverPurityCalculatorJobDetails> InverseScrapSilverPurityCalculatorJobDetailsSilverCodeNavigation { get; set; }
    }
}
