using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _IAboutDal;

        public AboutManager(IAboutDal ıAboutDal)
        {
            _IAboutDal = ıAboutDal;
        }

        public void TAdd(About Added)
        {
            _IAboutDal.TAdd(Added);
        }

        public void TDelete(About Deleted)
        {
            _IAboutDal.TDelete(Deleted);
        }

        public void TUpdate(About Updated)
        {
            _IAboutDal.TUpdate(Updated);
        }

        public List<About> Listed()
        {
            return _IAboutDal.Listed();
        }

        public About GetID(int ID)
        {
            return _IAboutDal.GetList(ID);
        }
    }
}
