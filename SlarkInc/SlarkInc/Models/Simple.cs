using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlarkInc.Models
{
    public class Simple
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "E-Mail"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}