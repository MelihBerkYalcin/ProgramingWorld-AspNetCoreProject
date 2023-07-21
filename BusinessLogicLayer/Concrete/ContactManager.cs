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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact Added)
        {
            _contactDal.TAdd(Added);
        }

        public void TDelete(Contact Deleted)
        {
            _contactDal.TDelete(Deleted);
        }

        public void TUpdate(Contact Updated)
        {
            _contactDal.TUpdate(Updated);
        }

        public Contact GetID(int ID)
        {
            return _contactDal.GetList(ID);
        }

        public List<Contact> Listed()
        {
            return _contactDal.Listed();
        }
    }
}
