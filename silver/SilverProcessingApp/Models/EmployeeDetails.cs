using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class EmployeeDetails
    {

		[Key]
		public int EmployeeId { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Employee Name")]
		public string EmployeeName { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Job Type")]
		public string JobType { get; set; }

		[Column(TypeName = "numeric(10,2)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Salary")]
		public double Salary { get; set; }

	}
}
