using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlarkInc.Models
{
    public class DataAnnotationModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
         [RegularExpression(@"^\s*([A-Za-z0-9_-]+(\.\w+)*@([\w-]+\.)+\w{2,3})\s*$", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
    }
}