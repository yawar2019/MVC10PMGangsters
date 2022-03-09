using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC10PMGangsters.Models
{
    public class RegistrationModel
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Customer Name is Required")]
        public string CustomerName { get; set; }
        [Range(18,50,ErrorMessage ="18-50 only allowed")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage ="Password and Confirm Password not same")]
        public string ConfirmPwd { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Incorrect format of  EmailId")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="Only 10 is required")]
        public string Address { get; set; }
    }
}