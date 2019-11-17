using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Warehouse
    {
        [Key]
        public string w_code { get; set; }
        [Required]
        public string w_name { get; set; }
        [Required]
        public int w_amount { get; set; }
        [Required]
        public string w_location { get; set; }

    }
}
