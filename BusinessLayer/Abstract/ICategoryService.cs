using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category); // Not : Burada EntityLayer.Concrate kullanabilmek icin Dependencies --> Project kısmına referansın eklenmiş olması gerekiyor
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetCategories();
        Category GetByID(int id);
    }
}
