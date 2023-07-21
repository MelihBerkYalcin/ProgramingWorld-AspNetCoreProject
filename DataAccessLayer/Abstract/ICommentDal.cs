using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Comment GetCommentByBlog(int ID);
        List<Comment> CommentList();
        List<Comment> CommentByID(int ID);
        List<Comment> CommentGetByID(int ID);
    }
}
