using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class Customermodel
    {
        [Required]
        [Display(Name = "ProductNameInput")]
        public string ProductNameInput { get; set; }

        [Display(Name = "ConfirmOrder")]
        public string ConfirmOrder { get; set; }

        [Display(Name = "Showcart")]
        public string Showcart { get; set; }

        [Display(Name = "Searchinput")]
        public string Searchinput { get; set; }

        [Display(Name = "Clearcart")]
        public string Clearcart { get; set; }
    }
}