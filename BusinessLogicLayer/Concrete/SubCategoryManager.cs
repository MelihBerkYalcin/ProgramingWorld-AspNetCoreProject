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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void TAdd(SubCategory Added)
        {
            _subCategoryDal.TAdd(Added);
        }

        public void TDelete(SubCategory Deleted)
        {
            _subCategoryDal.TDelete(Deleted);
        }

        public void TUpdate(SubCategory Updated)
        {
            _subCategoryDal.TUpdate(Updated);
        }
        public SubCategory GetID(int ID)
        {
            return _subCategoryDal.GetList(ID);
        }

        public List<SubCategory> Listed()
        {
            return _subCategoryDal.Listed();
        }

        public List<SubCategory> SubCategoryListGetCategory()
        {
            return _subCategoryDal.SubCategoryListGetCategory();
        }
    }
}
