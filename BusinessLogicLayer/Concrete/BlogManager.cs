using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog Added)
        {
            _blogDal.TAdd(Added);
        }

        public void TDelete(Blog Deleted)
        {
            _blogDal.TDelete(Deleted);
        }

        public void TUpdate(Blog Updated)
        {
            _blogDal.TUpdate(Updated);
        }

        public Blog GetID(int ID)
        {
            return _blogDal.GetList(ID);
        }

        public List<Blog> Listed()
        {
            return _blogDal.Listed();
        }

        public List<Blog> BlogWithCategoryGet()
        {
            return _blogDal.BlogWithCategoryGet();
        }

        public List<Blog> GetByBlogID(int ID)
        {
            return _blogDal.Listed(I => I.BlogID == ID);
        }

        public List<Blog> BlogAndCategoryGetList(Expression<Func<Blog, bool>> Filter)
        {
            return _blogDal.BlogAndCategoryGetList(Filter);
        }

        public List<Blog> BlogAndCategoryAndSearchGetList(string p)
        {
            return _blogDal.BlogAndCategoryAndSearchGetList(p);
        }

        public Blog GetBlogById(int ID)
        {
            return _blogDal.GetBlogById(ID);
        }

        public List<Blog> BlogAndSubCategoryGetList(Expression<Func<Blog, bool>> Filter)
        {
            return _blogDal.BlogAndSubCategoryGetList(Filter);
        }
    }
}
