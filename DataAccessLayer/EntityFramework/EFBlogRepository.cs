using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var _context = new Context())
            {
                return _context.Blogs.Include(c => c.Category).ToList();
            }
        }
    }
}
