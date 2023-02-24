/***********************************************************************
 * Module:  SurgeryService.cs
 * Purpose: Definition of the Class Service.SurgeryService
 ***********************************************************************/

using System;

namespace Service
{
   public class SurgeryService
   {
      public Model.Doctor.Surgery ScheduleSurgery(Model.Doctor.Surgery surgery)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Surgery EditSurgerySchedule(Model.Doctor.Surgery surgery)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelSurgery(Model.Doctor.Surgery surgery)
      {
         // TODO: implement
         return false;
      }
      
      public SurgeryService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SurgeryService()
      {
         // TODO: implement
      }
   
      public Repository.SurgeryRepository surgeryRepository;

        private static SurgeryService instance = null;

        public static SurgeryService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurgeryService();
                }
                return instance;
            }
        }

    }
}