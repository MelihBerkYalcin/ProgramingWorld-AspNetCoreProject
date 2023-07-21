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
    public class CommentReplyManager : ICommandReplyService
    {
        ICommentReplyDal _commentReplyDal;

        public CommentReplyManager(ICommentReplyDal commentReplyDal)
        {
            _commentReplyDal = commentReplyDal;
        }

        public void TAdd(CommentReply Added)
        {
            _commentReplyDal.TAdd(Added);
        }

        public void TDelete(CommentReply Deleted)
        {
            _commentReplyDal.TDelete(Deleted);
        }

        public void TUpdate(CommentReply Updated)
        {
            _commentReplyDal.TUpdate(Updated);
        }

        public CommentReply GetID(int ID)
        {
            return _commentReplyDal.GetList(ID);
        }

        public List<CommentReply> Listed()
        {
            return _commentReplyDal.Listed();
        }

        public List<CommentReply> GetByCommentReplyID(Expression<Func<CommentReply, bool>> filter)
        {
            return _commentReplyDal.GetByCommentReplyID(filter);
        }
    }
}
