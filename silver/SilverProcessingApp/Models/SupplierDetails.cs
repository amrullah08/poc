using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class SupplierDetails
    {
		[Key]
		public int SupplierCode { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Name of the Supplier")]
		public string SupplierName { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Supplier Phone NO")]
		public string SupplierPhoneNo { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Quantity of Salary Buyed")]
		public double QuantityBuyed { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Total Amount")]
		public double TotalAmount { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Amount Payed")]
		public double AmountPayed { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Outstanding Amount/Balance")]
		public double OutstandingAmount { get; set; }
	}
}
