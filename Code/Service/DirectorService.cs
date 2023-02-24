/***********************************************************************
 * Module:  DirectorService.cs
 * Purpose: Definition of the Class Service.DirectorService
 ***********************************************************************/

using Model.PatientSecretary;
using Model.User;
using System;

namespace Service
{
   public class DirectorService
   {
      public Doctor AddDoctor(Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Secretary AddSecretary(Secretary secretary)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteDoctor(Doctor doctor)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteSecretary(Secretary secretary)
      {
         // TODO: implement
         return false;
      }
      
      public DirectorService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DirectorService()
      {
         // TODO: implement
      }
   
      public Repository.DirectorRepository directorRepository;
   
      private static DirectorService instance = null;

        public static DirectorService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DirectorService();
                }
                return instance;
            }
        }

    }
}