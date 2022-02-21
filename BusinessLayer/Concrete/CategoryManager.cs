using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository eFCategoryRepository;

        public CategoryManager()
        {
            eFCategoryRepository = new EFCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            eFCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            eFCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            eFCategoryRepository.Update(category);
        }

        public Category GetByID(int id)
        {
            return eFCategoryRepository.GetByID(id);
        }

        public List<Category> GetCategories()
        {
            return eFCategoryRepository.GetAll();
        }
    }
}
