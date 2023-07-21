using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> BlogWithCategoryGet();
        List<Blog> BlogAndCategoryGetList(Expression<Func<Blog, bool>> Filter);
        List<Blog> BlogAndSubCategoryGetList(Expression<Func<Blog, bool>> Filter);
        List<Blog> BlogAndCategoryAndSearchGetList(string p);
        Blog GetBlogById(int ID);
    }
}
