/***********************************************************************
 * Module:  NotificationController.cs
 * Purpose: Definition of the Class Controller.NotificationController
 ***********************************************************************/

using Model.User;
using System;

namespace Controller
{
   public class NotificationController
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
      
      public NotificationController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private NotificationController()
      {
         // TODO: implement
      }
   
      public Service.NotificationService notificationService;
   
      private static NotificationController instance=null;

        public static NotificationController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationController();
                }
                return instance;
            }
        }

    }
}