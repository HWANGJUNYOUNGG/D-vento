using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "품목명")]
        public string Title { get; set; }

        [Display(Name = "수정날짜")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "브랜드")]
        public string Genre { get; set; }

        [Display(Name = "소비자가격")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "단위")]
        public string Rating { get; set; }
    }
}