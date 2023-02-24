/***********************************************************************
 * Module:  DirectorController.cs
 * Purpose: Definition of the Class Controller.DirectorController
 ***********************************************************************/

using Model.PatientSecretary;
using Model.User;
using System;

namespace Controller
{
   public class DirectorController
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
      
      public DirectorController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DirectorController()
      {
         // TODO: implement
      }
   
      public Service.DirectorService directorService;
   
      private static DirectorController instance=null;

        public static DirectorController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DirectorController();
                }
                return instance;
            }
        }

    }
}