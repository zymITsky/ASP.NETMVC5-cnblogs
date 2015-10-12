using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlarkInc.Models
{
    public class Worker
    {
        public int ID { get; set; }

        [Required,Display(Name = "Last Name"),DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required,Display(Name = "First Name"),DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required,Display(Name = "性别")]
        public Sex Sex { get; set; }

        public double? Rating { get; set; }
    }

    public enum Sex
    {
        [Display(Name = "男")]
        Male,
        [Display(Name = "女")]
        Female
    }
}