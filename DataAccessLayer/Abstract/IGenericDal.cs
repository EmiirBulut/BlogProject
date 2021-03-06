using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetAll();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        T GetByID(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter); // filtreli listeleme operasyonları icin yazılmıs bir metot


    }
}
