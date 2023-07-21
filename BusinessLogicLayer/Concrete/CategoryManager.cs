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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category Added)
        {
            _categoryDal.TAdd(Added);
        }

        public void TDelete(Category Deleted)
        {
            _categoryDal.TDelete(Deleted);
        }

        public void TUpdate(Category Updated)
        {
            _categoryDal.TUpdate(Updated);
        }
        public Category GetID(int ID)
        {
            return _categoryDal.GetList(ID);
        }

        public List<Category> Listed()
        {
            return _categoryDal.Listed();
        }
    }
}
