/***********************************************************************
 * Module:  WorkTimeController.cs
 * Purpose: Definition of the Class Controller.WorkTimeController
 ***********************************************************************/

using System;

namespace Controller
{
   public class WorkTimeController
   {
      public Model.Director.WorkTime AddWorkTime(Model.Director.WorkTime workTime, Model.User.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.WorkTime ChangeWorkTime(Model.Director.WorkTime workTime, Model.User.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.WorkTime DeleteWorkTime(Model.Director.WorkTime workTime, Model.User.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.AnnualLeave AddAnnualLeave(Model.Director.AnnualLeave annualLeave)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.AnnualLeave ChangeAnnualLeave(Model.Director.AnnualLeave annualLeave)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.AnnualLeave DeleteAnnualLeave(Model.Director.AnnualLeave annualLeave)
      {
         // TODO: implement
         return null;
      }
      
      public WorkTimeController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private WorkTimeController()
      {
         // TODO: implement
      }
   
      public Service.WorkTimeService workTimeService;

        private static WorkTimeController instance = null;

        public static WorkTimeController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkTimeController();
                }
                return instance;
            }
        }

    }
}