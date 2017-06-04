using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "username")]
        public string username { get; set; }

        [Required]
        [Display(Name = "password")]
        public string password { get; set; }
    }
}