using System.ComponentModel.DataAnnotations;

namespace BooksApp.MVC.Areas.Admin.Models
{
    public class CategoryAddViewModel
    {

        [Required(ErrorMessage = "Ad alanı boş bırakılmamalıdır!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılmamalıdır.")]
        public string Description { get; set; }


        public bool IsActive { get; set; }
    }
}
