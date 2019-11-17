using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "사용자 ID를 입력하세요")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "사용자 비빌번호를 입력하세요")]
        public string UserPassword { get; set; }
    }
}
