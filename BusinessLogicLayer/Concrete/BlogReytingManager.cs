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
    public class BlogReytingManager : IBlogReytingService
    {
        IBlogReytingDal _blogReytingDal;

        public BlogReytingManager(IBlogReytingDal blogReytingDal)
        {
            _blogReytingDal = blogReytingDal;
        }

        public void TAdd(BlogReyting Added)
        {
            _blogReytingDal.TAdd(Added);
        }

        public void TDelete(BlogReyting Deleted)
        {
            _blogReytingDal.TDelete(Deleted);
        }

        public void TUpdate(BlogReyting Updated)
        {
            _blogReytingDal.TUpdate(Updated);
        }

        public BlogReyting GetID(int ID)
        {
            return _blogReytingDal.GetList(ID);
        }

        public List<BlogReyting> Listed()
        {
            return _blogReytingDal.Listed();
        }
    }
}
