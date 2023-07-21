using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUsersDal _appUsersDal;

        public AppUserManager(IAppUsersDal appUsersDal)
        {
            _appUsersDal = appUsersDal;
        }

        public void TAdd(AppUser Added)
        {
            _appUsersDal.TAdd(Added);
        }

        public void TDelete(AppUser Deleted)
        {
            _appUsersDal.TDelete(Deleted);
        }

        public void TUpdate(AppUser Updated)
        {
            _appUsersDal.TUpdate(Updated);
        }
        public AppUser GetID(int ID)
        {
            return _appUsersDal.GetList(ID);
        }

        public List<AppUser> Listed()
        {
            return _appUsersDal.Listed();
        }

        public List<AppUser> GetUserByID(int ID)
        {
            return _appUsersDal.Listed(I => I.Id == ID);
        }
    }
}
