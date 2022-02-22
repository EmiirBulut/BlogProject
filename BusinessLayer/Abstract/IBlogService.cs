using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog); // Not : Burada EntityLayer.Concrate kullanabilmek icin Dependencies --> Project kısmına referansın eklenmiş olması gerekiyor
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetBlogs();
        Blog GetByID(int id);
        List<Blog> GetBlogsWithCategory();
    }
}
