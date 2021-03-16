using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppcodeFirstpra.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        public int EmpID { get; set; }
        public string EName { get; set; }
        public double ESalary { get; set; }
        public DateTime EDoj { get; set; }
    }
}