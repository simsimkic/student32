/***********************************************************************
 * Module:  NotificationService.cs
 * Purpose: Definition of the Class Service.UserServices.NotificationService
 ***********************************************************************/

using Model.User;
using System;

namespace Service
{
    public class NotificationService
    {
        public Notification SendNotification(Notification notification, String receiver)
        {
            // TODO: implement
            return null;
        }

        public Notification ReadNotification(Notification notification)
        {
            // TODO: implement
            return null;
        }

        public NotificationService GetInstance()
        {
            // TODO: implement
            return null;
        }

        private NotificationService()
        {
            // TODO: implement
        }

        public Repository.NotificationRepository notificationRepository;

        private static NotificationService instance = null;

        public static NotificationService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationService();
                }
                return instance;
            }
        }

    }
}