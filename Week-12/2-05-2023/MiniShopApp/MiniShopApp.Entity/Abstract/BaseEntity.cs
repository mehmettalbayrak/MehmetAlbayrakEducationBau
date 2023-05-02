using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; //Bunu ekleyebilmek için (DataTime.Now) Interface yapısından abstract class şekline getirdik.
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true; //Eklenen datayı aktif halde olmasını istediğimiz için default olan false değerini true yaptık.
        public virtual bool IsDeleted { get; set; } = false; //Default değeri zaten false olduğu için silinen datalarımız için kullanacağımız bu propertye bir şey eklemedik. Ama sonradan ne olur ne olmaz diye false olarak da ekledik.
    }
}
