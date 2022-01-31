using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class ScrapSilverPurityConvertorJob
    {
        public ScrapSilverPurityConvertorJob()
        {
            ScrapSilverPurityCalculatorJobDetails = new HashSet<ScrapSilverPurityCalculatorJobDetails>();
        }

        [Key]
        public int Pid { get; set; }
        public int ProductNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal ExpectedfinalPurity { get; set; }
        [StringLength(100)]
        public string FromBuyer { get; set; }
        [StringLength(100)]
        public string ToEndUser { get; set; }
        [Column(TypeName = "date")]
        public DateTime Dateofinput { get; set; }
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

        [InverseProperty("ScrapSilverPurityConvertorJobP")]
        public virtual ICollection<ScrapSilverPurityCalculatorJobDetails> ScrapSilverPurityCalculatorJobDetails { get; set; }
    }
}
