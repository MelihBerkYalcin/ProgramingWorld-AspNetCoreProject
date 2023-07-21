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
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public void TAdd(Advert Added)
        {
            _advertDal.TAdd(Added);
        }

        public void TDelete(Advert Deleted)
        {
            _advertDal.TDelete(Deleted);
        }

        public void TUpdate(Advert Updated)
        {
            _advertDal.TUpdate(Updated);
        }
        public Advert GetID(int ID)
        {
            return _advertDal.GetList(ID);
        }

        public List<Advert> Listed()
        {
            return _advertDal.Listed();
        }
    }
}
