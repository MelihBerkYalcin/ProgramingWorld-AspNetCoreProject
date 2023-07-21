using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        List<Message> GetByWriterWithMessage(int ID);
        List<Message> WriterSendBox(int ID);
        Message GetByID(int ID);
        List<Message> WriterGetByMessage(int ID);
        List<Message> WriterAllMessages();
    }
}
