using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Product
    {
        [Key]
        public string p_code { get; set; }

        [Required]
        public string p_name { get; set; }
        [Required]
        public int p_measure { get; set; }
        [Required]
        public int p_many { get; set; }
        [Required]
        public int p_comprice { get; set; }
        [Required]
        public string p_location { get; set; }
        [Required]
        public string p_amount { get; set; }
        [Required]
        public string p_brandname { get; set; }
        [Required]
        public int p_customerprice { get; set; }


    }
}
