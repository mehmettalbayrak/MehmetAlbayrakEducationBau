using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.MVC.Models
{
    public class ResetPasswordViewModel
    {
        public string UserId { get; set; }
        public string Token { get; set; }


        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Lütfen boş bırakmayınız.")]
        [PasswordPropertyText]
        public string Password { get; set; }
        [DisplayName("Şifre Tekrar")]
        [Required(ErrorMessage = "Lütfen boş bırakmayınız.")]
        [PasswordPropertyText]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmedi")]
        public string RePassword { get; set; }
    }
}
