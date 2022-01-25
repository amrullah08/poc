using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class BuyingRawSilver
    {
		[Key]
		public int SilverCode { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Raw Silver Quantity")]
		public double RawSilverQuantity { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("No Silver Units")]
		public double NoSilverUnits { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Grams Per Unit(in Gms)")]
		public double GramsPerUnit { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Silver Value(in Rupees)")]
		public double SilverValue { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("GST(in Rupees)")]
		public double GST { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Total Amount(in Rupees)")]
		public double TotalAmount { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Supplier Name")]
		public string SupplierName { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Supplier Phone NO")]
		public string SupplierPhoneNo { get; set; }

		[Column(TypeName = "date")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Date of Purchase")]
		public DateTime DateofPurchase { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string Mass { get; set; }

		[NotMapped]
		public List<SelectListItem> Units { get; } = new List<SelectListItem>
		{
			new SelectListItem { Value = "KG", Text = "KiloGrams" },
			new SelectListItem { Value = "Gms", Text = "Grams" },
			new SelectListItem { Value = "MM", Text = "Milligram"  },
		};

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Image Name")]
		public string ImageName { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Image Name2")]
		public string ImageName2 { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Image Name3")]
		public string ImageName3 { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Image Name4")]
		public string ImageName4 { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Image Name5")]
		public string ImageName5 { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("IP ADDRESS")]
		public string IPADDRESS { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("PC NAME")]
		public string PCNAME { get; set; }

		[NotMapped]
		[DisplayName("Upload File")]
		public IFormFile ImageFile { get; set; }

		[NotMapped]
		public List<string> Photos { get; set; }
	}
}
