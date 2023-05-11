using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Abstract
{
    //Abstract classda Virtual yapmamýzýn nedeni burada belirlediðimiz propertyleri daha sonrasýnda deðiþtirmek istersek diye.
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; 
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
