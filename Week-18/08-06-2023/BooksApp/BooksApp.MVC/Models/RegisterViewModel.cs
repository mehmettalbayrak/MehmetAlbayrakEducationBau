using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.MVC.Models
{
    public class RegisterViewModel
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage ="Ad alanı boş bırakılmamalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "Soyad alanı boş bırakılmamalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılmamalıdır.")]
        public string UserName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email alanı boş bırakılmamalıdır.")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Geçerli bir email adresi girilmelidir.")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılmamalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılmamalıdır.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="İki parola aynı olmamalıdır.")]
        public string RePassword { get; set; }
    }
}
