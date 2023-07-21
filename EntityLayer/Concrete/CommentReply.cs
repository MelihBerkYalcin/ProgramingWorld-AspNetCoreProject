using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommentReply
    {
        [Key]
        public int CommentReplyID { get; set; }
        public string CommentReplyUserName { get; set; }
        public string CommentReplyTitle { get; set; }
        public string CommentReplyContent { get; set; }
        public DateTime CommentReplyDate { get; set; }
        public bool CommentReplyStatus { get; set; }
        public int CommentID { get; set; }
        public Comment Comment { get; set; }
    }
}
