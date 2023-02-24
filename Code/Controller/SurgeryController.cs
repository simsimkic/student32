/***********************************************************************
 * Module:  SurgeryController.cs
 * Purpose: Definition of the Class Controller.SurgeryController
 ***********************************************************************/

using System;

namespace Controller
{
   public class SurgeryController
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
      
      public SurveyController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SurgeryController()
      {
         // TODO: implement
      }
   
      public Service.SurgeryService surgeryService;

        private static SurgeryController instance = null;

        public static SurgeryController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurgeryController();
                }
                return instance;
            }
        }

    }
}