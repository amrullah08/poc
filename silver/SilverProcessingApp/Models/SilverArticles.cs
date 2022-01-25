using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class SilverArticles
    {
		[Key]
		public int SilverArticleId { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Type of Silver Article")]
		public string TypeofSilverArticle { get; set; }

		[Column(TypeName = "date")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Date of Process")]
		public DateTime DateofProcess { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Name of the Employee")]
		public string Processby { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Raw Silver Quantity")]
		public double RawSilverQuantity { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Net Weight of Silver")]
		public double NetWeight { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Silver Value")]
		public double SilverValue { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Making Charges")]
		public double MakingCharges { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Wastage")]
		public double Wastage { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Total")]
		public double Total { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("GST")]
		public double GST { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Total Amount")]
		public double TotalAmount { get; set; }

	}
}
