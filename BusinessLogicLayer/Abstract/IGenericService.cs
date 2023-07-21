using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T Added);
        void TUpdate(T Updated);
        void TDelete(T Deleted);
        T GetID(int ID);
        List<T> Listed();
    }
}
