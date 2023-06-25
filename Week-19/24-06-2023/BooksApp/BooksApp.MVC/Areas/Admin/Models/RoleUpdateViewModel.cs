using BooksApp.Entity.Concrete;

namespace BooksApp.MVC.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        public Role Role { get; set; }
        public IList<User> Members { get; set; }
        public IList<User> NonMembers { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsFromRemove { get; set; }
    }
}
