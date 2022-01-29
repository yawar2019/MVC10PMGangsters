using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperEmple.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        //[ScaffoldColumn(false)]
        public int EmpSalary { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Managers { get; set; }
        public string EmailId { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }
        public bool agreement { get; set; }


    }



}