/***********************************************************************
 * Module:  SystemFeedbackService.cs
 * Purpose: Definition of the Class Service.SystemFeedbackService
 ***********************************************************************/

using Model.User;
using System;

namespace Service
{
   public class SystemFeedbackService
   {
      public SystemFeedback AddSystemFeedback(SystemFeedback systemFeedback)
      {
         // TODO: implement
         return null;
      }
      
      public SystemFeedback DeleteSystemFeedback(Boolean systemFeedback)
      {
         // TODO: implement
         return null;
      }
      
      public SystemFeedback EditSystemFeedback(SystemFeedback systemFeedback)
      {
         // TODO: implement
         return null;
      }
      
      public SystemFeedbackService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SystemFeedbackService()
      {
         // TODO: implement
      }
   
      public Repository.SystemFeedbackRepository systemFeedbackRepository;
   
      private static SystemFeedbackService instance = null;

        public static SystemFeedbackService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SystemFeedbackService();
                }
                return instance;
            }
        }

    }
}