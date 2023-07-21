using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        Context context = new Context();

        public void TAdd(T Added)
        {
            context.Set<T>().Add(Added);
            context.SaveChanges();
        }

        public void TDelete(T Deleted)
        {
            context.Set<T>().Remove(Deleted);
            context.SaveChanges();
        }

        public void TUpdate(T Updated)
        {
            context.Set<T>().Update(Updated);
            context.SaveChanges();
        }
        public T GetList(int ID)
        {
            return context.Set<T>().Find(ID);
        }

        public List<T> Listed()
        {
            return context.Set<T>().ToList();
        }

        public List<T> Listed(Expression<Func<T, bool>> Filter)
        {
            return context.Set<T>().Where(Filter).ToList();
        }

    }
}
