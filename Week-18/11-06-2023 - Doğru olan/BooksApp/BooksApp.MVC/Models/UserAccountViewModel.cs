using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.MVC.Models
{
    public class UserAccountViewModel
    {
        public string Id { get; set; }

        [DisplayName("İsim")]
        [Required(ErrorMessage = "İsim alanı boş bırakılmamalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyisim")]
        [Required(ErrorMessage = "Soyisim alanı boş bırakılmamalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Cinsiyet")]
        public string Gender { get; set; }

        [DisplayName("Doğum Tarihi")]
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        public string City { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılmamalıdır.")]
        public string UserName { get; set; }

        [DisplayName("E-Mail Adresi")]
        public string Email { get; set; }

        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        public List<SelectListItem> GenderSelectList { get; set; }
    }
}
