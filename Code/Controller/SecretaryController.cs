/***********************************************************************
 * Module:  SecretaryController.cs
 * Purpose: Definition of the Class Controller.SecretaryController
 ***********************************************************************/

using System;

namespace Controller
{
   public class SecretaryController
   {
      public Model.User.Patient RegisterPatient()
      {
         // TODO: implement
         return null;
      }
      
      public Model.User.Patient EditPatient(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.User.Patient GuestToRegularPatient(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public SecretaryController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SecretaryController()
      {
         // TODO: implement
      }
   
      public Service.SecretaryService secretaryService;

        private static SecretaryController instance = null;

        public static SecretaryController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SecretaryController();
                }
                return instance;
            }
        }

    }
}