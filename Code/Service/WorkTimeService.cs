/***********************************************************************
 * Module:  WorkTimeService.cs
 * Purpose: Definition of the Class Service.WorkTimeService
 ***********************************************************************/

using System;

namespace Service
{
   public class WorkTimeService
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
      
      public WorkTimeService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private WorkTimeService()
      {
         // TODO: implement
      }
   
      public Repository.WorkTimeRepository workTimeRepository;
   
      private static WorkTimeService instance = null;

        public static WorkTimeService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkTimeService();
                }
                return instance;
            }
        }

    }
}