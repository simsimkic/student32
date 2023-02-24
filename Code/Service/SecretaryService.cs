/***********************************************************************
 * Module:  SecretaryService.cs
 * Purpose: Definition of the Class Service.SecretaryService
 ***********************************************************************/

using System;

namespace Service
{
   public class SecretaryService
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
      
      public SecretaryService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SecretaryService()
      {
         // TODO: implement
      }
   
      public Repository.SecretaryRepository secretaryRepository;

        private static SecretaryService instance = null;

        public static SecretaryService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SecretaryService();
                }
                return instance;
            }
        }

    }
}