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
    public class AppRoleManager : IAppRoleService
    {
        IAppRoleDal _appRoleDal;

        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            _appRoleDal = appRoleDal;
        }

        public void TAdd(AppRole Added)
        {
            _appRoleDal.TAdd(Added);
        }

        public void TDelete(AppRole Deleted)
        {
            _appRoleDal.TDelete(Deleted);
        }

        public void TUpdate(AppRole Updated)
        {
            _appRoleDal.TUpdate(Updated);
        }
        public AppRole GetID(int ID)
        {
            return _appRoleDal.GetList(ID);
        }

        public List<AppRole> Listed()
        {
            return _appRoleDal.Listed();
        }
    }
}
