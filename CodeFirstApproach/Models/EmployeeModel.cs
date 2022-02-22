using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class employeeDetails
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
    }
}