using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class UpdatedListManager : IUpdatedListService
    {
        IUpdatedListDal _updatedListDal;

        public UpdatedListManager(IUpdatedListDal updatedListDal)
        {
            _updatedListDal = updatedListDal;
        }

        public void TAdd(Update Added)
        {
            _updatedListDal.TAdd(Added);
        }

        public void TUpdate(Update Updated)
        {
            _updatedListDal.TUpdate(Updated);
        }

        public void TDelete(Update Deleted)
        {
            _updatedListDal.TDelete(Deleted);
        }

        public Update GetID(int ID)
        {
            return _updatedListDal.GetList(ID);
        }

        public List<Update> Listed()
        {
            return _updatedListDal.Listed();
        }
    }
}
