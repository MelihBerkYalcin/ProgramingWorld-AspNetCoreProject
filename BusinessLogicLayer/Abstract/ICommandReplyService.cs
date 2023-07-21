using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ICommandReplyService : IGenericService<CommentReply>
    {
        List<CommentReply> GetByCommentReplyID(Expression<Func<CommentReply, bool>> filter);
    }
}
