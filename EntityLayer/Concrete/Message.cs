using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public int? ReceiverUserId { get; set; } // Receiver Alan Demek
        public int? SenderUserId { get; set; } // Sender Gönderen Demek
        public AppUser ReceiverUser { get; set; } // Receiver Alan Demek
        public AppUser SenderUser { get; set; } // Sender Gönderen Demek
    }
}
