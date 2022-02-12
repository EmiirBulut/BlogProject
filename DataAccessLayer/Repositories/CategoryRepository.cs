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
    public class CategoryRepository : ICategoryDal
    {
        Context _context = new Context();
        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryByID(int id)
        {
            //return _context.Categories.FirstOrDefault(c => c.CategoryID == id);
            return _context.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();

        }
    }
}
