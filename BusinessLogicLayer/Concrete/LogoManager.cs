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
    public class LogoManager : ILogoService
    {
        ILogoDal _logoDal;

        public LogoManager(ILogoDal logoDal)
        {
            _logoDal = logoDal;
        }

        public void TAdd(Logo Added)
        {
            _logoDal.TAdd(Added);
        }

        public void TDelete(Logo Deleted)
        {
            _logoDal.TDelete(Deleted);
        }

        public void TUpdate(Logo Updated)
        {
            _logoDal.TUpdate(Updated);
        }
        public Logo GetID(int ID)
        {
            return _logoDal.GetList(ID);
        }

        public List<Logo> Listed()
        {
            return _logoDal.Listed();
        }
    }
}
