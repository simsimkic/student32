/***********************************************************************
 * Module:  RenovationService.cs
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using System;

namespace Service
{
   public class RenovationService
   {
      public Model.Director.Renovation AddRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return false;
      }
      
      public Model.Director.Renovation EditRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public RenovationService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private RenovationService()
      {
         // TODO: implement
      }
   
      public Repository.RenovationRepository renovationRepository;
   
      private static RenovationService instance = null;

        public static RenovationService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenovationService();
                }
                return instance;
            }
        }

    }
}