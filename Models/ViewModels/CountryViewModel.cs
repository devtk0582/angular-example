using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularExample.Models.ViewModels
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        [Display(Name = "ISO3 Code")]
        public string ISO3Code { get; set; }
    }
}