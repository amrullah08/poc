using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Models
{
    public class dateforexcel
    {
        [DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }
    }
}
