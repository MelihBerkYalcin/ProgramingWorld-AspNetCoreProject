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
    public class EFMessageRepository : GenericRepository<Message>, IMessageDal
    {
        Context context = new Context();
        public List<Message> GetByWriterWithMessage(int ID)
        {
            return context.Message.Include(I => I.SenderUser).Include(I => I.ReceiverUser).Where(I => I.ReceiverUserId == ID).ToList();
        }

        public List<Message> WriterSendBox(int ID)
        {
            return context.Message.Include(I => I.SenderUser).Include(I => I.ReceiverUser).Where(I => I.SenderUserId == ID).ToList();
        }

        public Message GetByID(int ID)
        {
            return context.Message.Include(I => I.SenderUser).Include(I => I.ReceiverUser).FirstOrDefault(I => I.MessageID == ID);
        }

        public List<Message> WriterAllMessages()
        {
            return context.Message.Include(I => I.SenderUser).Include(I => I.ReceiverUser).ToList();
        }

        public List<Message> WriterGetByMessage(int ID)
        {
            return context.Message.Include(I => I.SenderUser).Include(I=>I.ReceiverUser).Where(I => I.MessageID == ID).ToList();
        }
    }
}
