using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void TAdd(T Added);
        void TUpdate(T Updated);
        void TDelete(T Deleted);
        List<T> Listed();
        T GetList(int ID);
        List<T> Listed(Expression<Func<T, bool>> Filter);
    }
}
