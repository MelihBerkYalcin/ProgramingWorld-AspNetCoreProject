using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        Context context = new Context();

        public List<Blog> BlogWithCategoryGet()
        {
            return context.Blog.Include(I => I.Category).Include(I => I.AppUser).ToList();
        }

        public List<Blog> BlogAndCategoryGetList(Expression<Func<Blog, bool>> Filter)
        {
            return context.Blog.Include(I => I.Category).Include(I => I.AppUser).Where(Filter).ToList();
        }

        public List<Blog> BlogAndSubCategoryGetList(Expression<Func<Blog, bool>> Filter)
        {
            return context.Blog.Include(I => I.SubCategory).Include(I => I.AppUser).Include(I => I.Category).Where(Filter).ToList();
        }

        public List<Blog> BlogAndCategoryAndSearchGetList(string p)
        {
            return context.Blog.Include(I => I.Category).Include(I => I.AppUser).Where(I => I.BlogTitle.Contains(p)).ToList();
        }

        public Blog GetBlogById(int ID)
        {
            return context.Blog.Include(I => I.Category).Include(I => I.AppUser).FirstOrDefault(I => I.BlogID == ID);
        }
    }
}
