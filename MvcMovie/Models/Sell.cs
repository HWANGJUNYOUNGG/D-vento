using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Sell
    {
        [Key]
        public string s_code { get; set; }

        [Required]
        [Display(Name = "제품명")]
        public string s_name { get; set; }

        [Required]
        [Display(Name = "판매날짜")]
        [DataType(DataType.Date)]
        public DateTime SellDate { get; set; }

        [Required]
        [Display(Name = "수량")]
        public int s_amount { get; set; }

        [Required]
        [Display(Name = "판매가격")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "마진율")]
        public string Rating { get; set; }
    }
}

