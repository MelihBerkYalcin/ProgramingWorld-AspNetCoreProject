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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia Added)
        {
            _socialMediaDal.TAdd(Added);
        }

        public void TDelete(SocialMedia Deleted)
        {
            _socialMediaDal.TDelete(Deleted);
        }

        public void TUpdate(SocialMedia Updated)
        {
            _socialMediaDal.TUpdate(Updated);
        }

        public SocialMedia GetID(int ID)
        {
            return _socialMediaDal.GetList(ID);
        }

        public List<SocialMedia> Listed()
        {
            return _socialMediaDal.Listed();
        }
    }
}
