using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class User
    {
        [Key]
        public int UserNo { get; set; }
        [Required(ErrorMessage = "사용자 ID을 입력하세요")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "사용자 이름를 입력하세요")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "사용자 비빌번호를 입력하세요")]
        public string UserPassword { get; set; }
    }
}
