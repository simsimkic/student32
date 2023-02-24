/***********************************************************************
 * Module:  SystemFeedback.cs
 * Purpose: Definition of the Class Model.User.SystemFeedback
 ***********************************************************************/

using System;

namespace Model.User
{
   /// - prijava gresaka ili predlog za prosirenje/dodatak aplikaciji
   public class SystemFeedback
   {
      public User user;

      public String Description { get; set; }
      public DateTime Date { get; set; }
      public int IdSystemFeedback { get; set; }

        public SystemFeedback(User user, string description, DateTime date, int idSystemFeedback)
        {
            this.user = user;
            Description = description;
            Date = date;
            IdSystemFeedback = idSystemFeedback;
        }
    }
}