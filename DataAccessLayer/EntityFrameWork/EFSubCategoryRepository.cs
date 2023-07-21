using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EFSubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryDal
    {
        Context context = new Context();

        public List<SubCategory> SubCategoryListGetCategory()
        {
            return context.SubCategory.Include(I => I.Category).ToList();
        }
    }
}
