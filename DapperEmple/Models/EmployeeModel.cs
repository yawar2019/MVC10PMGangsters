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

        [Required(ErrorMessage ="Employee Name is Empty")]
        public string EmpName { get; set; }
        //[ScaffoldColumn(false)]
        [Required(ErrorMessage = "Employee Salary is Empty")]
        [Range(20000,90000,ErrorMessage ="20000-90000 allowed")]
        public int EmpSalary { get; set; }

        [Required(ErrorMessage = "Password is Empty")]

        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm Password Mismatch")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Managers is Empty")]
        public string Managers { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        public string Gender { get; set; }

        [StringLength(10,ErrorMessage ="Only 10 characters allowed")]
        public string Address { get; set; }
        [Required]
        public bool agreement { get; set; }


    }



}