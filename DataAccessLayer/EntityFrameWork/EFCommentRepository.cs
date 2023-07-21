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
    public class EFCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        Context context = new Context();

        public List<Comment> CommentByID(int ID)
        {
            return context.Comment.Where(I => I.BlogID == ID).ToList();
        }

        public List<Comment> CommentGetByID(int ID)
        {
            return context.Comment.Where(I => I.CommentID == ID).ToList();
        }

        public List<Comment> CommentList()
        {
            return context.Comment.Include(I => I.Blog).ToList();
        }

        public Comment GetCommentByBlog(int ID)
        {
            return context.Comment.Include(I => I.Blog).FirstOrDefault(I => I.CommentID == ID);
        }
    }
}
