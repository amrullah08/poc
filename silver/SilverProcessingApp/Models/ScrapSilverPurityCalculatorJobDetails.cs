using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{

    public class ScrapSilverPurityCalculatorJobDetails
    {
        [Key]
        public int SilverCode { get; set; }

		[Column(TypeName = "int")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Product Number")]
		public int ProductNumber { get; set; }

		[Column(TypeName = "numeric(10,2)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Silver Quantity in Grams")]
		public double QuantityinGms { get; set; }

		[Column(TypeName = "numeric(10,2)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Percentage to Make 100% Pure.")]
		public double PercentageTomakepure { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Pure Silver Quantity")]
		public double PureSilver { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Enter the expected Final Purity.")]
		public double ExpectedfinalPurity { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[DisplayName("Final Purity.")]
		public double FinalPurity { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[DisplayName("Final Value.")]
		public double FinalValue { get; set; }

		[NotMapped]
		[DisplayName("Total Impure Silver Quantity")]
		public double TotalImpureQuantity { get; set; }

		[NotMapped]
		[DisplayName("Total Pure Silver Quantity")]
		public double TotalPureQuantity { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Pid")]
        public int Pido { get; set; }


		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Description")]
		public string Description { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("IP ADDRESS")]
		public string IPADDRESS { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("PC NAME")]
		public string PCNAME { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("User ID")]
		public string UserId { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("User Name")]
		public string UserName { get; set; }

		[Column(TypeName = "DateTime")]
		[DisplayName("LastModified")]
		public DateTime LastModified { get; set; }

		//[ForeignKey("PurityConvertor")]//very important
		//public int Pid { get; set; }
		//public virtual PurityConvertor PurityConvertor { get; private set; } //very important 

		public List<ScrapSilverPurityCalculatorJobDetails> PurityCalculators { get; set; }
	}

}

