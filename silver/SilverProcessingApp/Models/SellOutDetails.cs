using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class SellOutDetails
    {
		[Key]
		public int SelloutId { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Bill No")]
		public string BillNo { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "Sold by")]
		[DisplayName("Sold by")]
		public string Soldby { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "Customer Name")]
		[DisplayName("Customer Name")]
		public string CustomerName { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "Customer PhoneNo")]
		[DisplayName("Customer Phone No")]
		public string CustomerPhoneNo { get; set; }

		[Column(TypeName = "date")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Sell Out Date")]
		public DateTime Selloutdate { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Sell Out Value")]
		public double Selloutvalue { get; set; }

	}
}
