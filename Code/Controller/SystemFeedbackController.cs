/***********************************************************************
 * Module:  SystemFeedbackController.cs
 * Purpose: Definition of the Class Controller.SystemFeedbackController
 ***********************************************************************/

using Model.User;
using System;

namespace Controller
{
   public class SystemFeedbackController
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
      
      public SystemFeedbackController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SystemFeedbackController()
      {
         // TODO: implement
      }
   
      public Service.SystemFeedbackService systemFeedbackService;

        private static SystemFeedbackController instance = null;

        public static SystemFeedbackController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SystemFeedbackController();
                }
                return instance;
            }
        }

    }
}