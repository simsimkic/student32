/***********************************************************************
 * Module:  Notification.cs
 * Purpose: Definition of the Class Patient.Notification
 ***********************************************************************/

using System;

namespace Model.User
{
   public class Notification
   {
      public String Title { get; set; }
      public String Description { get; set; }
      public DateTime PublishingDate { get; set; }
      public int NotificationId { get; set; }

        public Notification(string title, string description, DateTime publishingDate, int notificationId)
        {
            Title = title;
            Description = description;
            PublishingDate = publishingDate;
            NotificationId = notificationId;
        }
    }
}