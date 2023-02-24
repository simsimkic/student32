/***********************************************************************
 * Module:  NotificationRepository.cs
 * Purpose: Definition of the Class Repository.NotificationRepository
 ***********************************************************************/

using Model.User;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class NotificationRepository : INotificationRepository
   {
      private String Path;

        public Notification AddNotificationTo(string senderUsername, string receiverUsername)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public object Edit()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAllNotificationByUser(object username)
        {
            throw new NotImplementedException();
        }

        public Notification GetNotificationById(int notificationId)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Save()
        {
            throw new NotImplementedException();
        }
    }
}