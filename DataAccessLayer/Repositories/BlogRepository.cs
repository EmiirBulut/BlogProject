using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using (var _context = new Context())
            {
                _context.Add(blog);
                _context.SaveChanges();
            }
        }

        public void DeleteBlog(Blog blog)
        {
            using (var _context = new Context())
            {
                _context.Remove(blog);
                _context.SaveChanges();
            }
        }

        public List<Blog> GetAllBlogs()
        {
            using (var _context = new Context())
            {
                return _context.Blogs.ToList();
            }
        }

        public Blog GetBlogByID(int id)
        {
            using (var _context = new Context())
            {
                return _context.Blogs.Find(id);
            }
        }

        public void UpdateBlog(Blog blog)
        {
            using (var _context = new Context())
            {
                _context.Update(blog);
                _context.SaveChanges();
            }
        }
    }
}
