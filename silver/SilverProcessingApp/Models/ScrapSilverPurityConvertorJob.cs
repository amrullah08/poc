using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
	public class ScrapSilverPurityConvertorJob
	{
		[Key]
		public int Pid { get; set; }

		[Column(TypeName = "int")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Product Number")]
		public int ProductNo { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Description")]
		public string Description { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Enter the expected Final Purity.")]
		public double ExpectedfinalPurity { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("From-Buyer")]
		public string FromBuyer { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("To-EndUser")]
		public string ToEndUser { get; set; }

		[Column(TypeName = "date")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Date")]
		public DateTime Dateofinput { get; set; }
		//[NotMapped]
		//public String FromDate { get; set; }

		//[NotMapped]
		//public String ToDate { get; set; }
		//List<ScrapSilverPurityConvertorJob> GetProductData();

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

		public List<ScrapSilverPurityCalculatorJobDetails> PurityCalculators { get; set; }
    }
}