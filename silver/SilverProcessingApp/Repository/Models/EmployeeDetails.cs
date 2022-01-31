using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverProcessingApp.Repository.Models
{
    public partial class EmployeeDetails
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(100)]
        public string JobType { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal Salary { get; set; }
    }
}
