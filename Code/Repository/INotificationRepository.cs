/***********************************************************************
 * Module:  INotificationRepository.cs
 * Purpose: Definition of the Interface Repository.INotificationRepository
 ***********************************************************************/

using Model.User;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface INotificationRepository : IRepository
   {
      List<Notification> GetAllNotificationByUser(Object username);
      Model.User.Notification GetNotificationById(int notificationId);
      Model.User.Notification AddNotificationTo(String senderUsername, String receiverUsername);
   }
}