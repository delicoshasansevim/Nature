using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Person
    {
       
     
        [Required(ErrorMessage ="please, do enter name")]
        public string Name { get; set; }


       // [StringLength(3, ErrorMessage = "The {0} must be at least {2} characters long")]
        [Required(ErrorMessage ="please, do enter email adreeess")]
        //[MaxLength(4)]
        [EmailAddress]
        public string EmailAdress { get; set; }

        [Required(ErrorMessage ="there is no text")]
        [MinLength(10)]
        public string EmailMessage { get; set; }
    }
}