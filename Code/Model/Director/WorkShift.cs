/***********************************************************************
 * Module:  WorkShift.cs
 * Purpose: Definition of the Class Model.Director.WorkShift
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class WorkShift
   {
      public System.Collections.ArrayList workTime;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetWorkTime()
      {
         if (workTime == null)
            workTime = new System.Collections.ArrayList();
         return workTime;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetWorkTime(System.Collections.ArrayList newWorkTime)
      {
         RemoveAllWorkTime();
         foreach (WorkTime oWorkTime in newWorkTime)
            AddWorkTime(oWorkTime);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddWorkTime(WorkTime newWorkTime)
      {
         if (newWorkTime == null)
            return;
         if (this.workTime == null)
            this.workTime = new System.Collections.ArrayList();
         if (!this.workTime.Contains(newWorkTime))
         {
            this.workTime.Add(newWorkTime);
            newWorkTime.SetWorkShift(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveWorkTime(WorkTime oldWorkTime)
      {
         if (oldWorkTime == null)
            return;
         if (this.workTime != null)
            if (this.workTime.Contains(oldWorkTime))
            {
               this.workTime.Remove(oldWorkTime);
               oldWorkTime.SetWorkShift((WorkShift)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllWorkTime()
      {
         if (workTime != null)
         {
            System.Collections.ArrayList tmpWorkTime = new System.Collections.ArrayList();
            foreach (WorkTime oldWorkTime in workTime)
               tmpWorkTime.Add(oldWorkTime);
            workTime.Clear();
            foreach (WorkTime oldWorkTime in tmpWorkTime)
               oldWorkTime.SetWorkShift((WorkShift)null);
            tmpWorkTime.Clear();
         }
      }
   
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }

        public WorkShift(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}