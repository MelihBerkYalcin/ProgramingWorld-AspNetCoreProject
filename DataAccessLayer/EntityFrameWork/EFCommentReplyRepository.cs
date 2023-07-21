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
    public class EFCommentReplyRepository : GenericRepository<CommentReply>, ICommentReplyDal
    {
        Context context = new Context();

        public List<CommentReply> GetByCommentReplyID(Expression<Func<CommentReply, bool>> filter)
        {
            return context.CommentReply.Where(filter).OrderByDescending(I => I.CommentID).ToList();
        }
    }
}
