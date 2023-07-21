using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment Added)
        {
            _commentDal.TAdd(Added);
        }

        public void TDelete(Comment Deleted)
        {
            _commentDal.TDelete(Deleted);
        }

        public void TUpdate(Comment Updated)
        {
            _commentDal.TUpdate(Updated);
        }

        public List<Comment> GetedID(int ID)
        {
            return _commentDal.Listed(I => I.BlogID == ID);
        }

        public List<Comment> Listed()
        {
            return _commentDal.Listed();
        }

        public Comment GetID(int ID)
        {
            return _commentDal.GetList(ID);
        }

        public List<Comment> GetCommentByBlog(int ID)
        {
            return _commentDal.Listed(I => I.CommentID == ID);
        }

        Comment ICommentService.GetCommentByBlog(int ID)
        {
            return _commentDal.GetCommentByBlog(ID);
        }

        public List<Comment> CommentList()
        {
            return _commentDal.CommentList();
        }

        public List<Comment> CommentByID(int ID)
        {
            return _commentDal.CommentByID(ID);
        }

        public List<Comment> CommentGetByID(int ID)
        {
            return _commentDal.CommentGetByID(ID);
        }
    }
}
