using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.MVC.Models
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı alanı boş bırakılmamalıdır.")]
        public string UserName { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılmamalıdır.")]

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
