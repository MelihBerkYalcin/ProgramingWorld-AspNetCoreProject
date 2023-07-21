using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification Added)
        {
            _notificationDal.TAdd(Added);
        }

        public void TDelete(Notification Deleted)
        {
            _notificationDal.TDelete(Deleted);
        }

        public void TUpdate(Notification Updated)
        {
            _notificationDal.TUpdate(Updated);
        }
        public Notification GetID(int ID)
        {
            return _notificationDal.GetList(ID);
        }

        public List<Notification> Listed()
        {
            return _notificationDal.Listed();
        }
    }
}
