using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message Added)
        {
            _messageDal.TAdd(Added);
        }

        public void TDelete(Message Deleted)
        {
            _messageDal.TDelete(Deleted);
        }

        public void TUpdate(Message Updated)
        {
            _messageDal.TUpdate(Updated);
        }

        public Message GetID(int ID)
        {
            return _messageDal.GetList(ID);
        }

        public List<Message> Listed()
        {
            return _messageDal.Listed();
        }

        public List<Message> GetByWriterWithMessage(int ID)
        {
            return _messageDal.GetByWriterWithMessage(ID);
        }

        public List<Message> WriterSendBox(int ID)
        {
            return _messageDal.WriterSendBox(ID);
        }

        public Message GetByID(int ID)
        {
            return _messageDal.GetByID(ID);
        }

        public List<Message> WriterAllMessages()
        {
            return _messageDal.WriterAllMessages();
        }

        public List<Message> WriterGetByMessage(int ID)
        {
            return _messageDal.WriterGetByMessage(ID);
        }
    }
}
