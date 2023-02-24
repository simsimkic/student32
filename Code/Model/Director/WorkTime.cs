/***********************************************************************
 * Module:  WorkTime.cs
 * Purpose: Definition of the Class Model.Director.WorkTime
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class WorkTime
   {
      public WorkShift workShift;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public WorkShift GetWorkShift()
      {
         return workShift;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newWorkShift</param>
      public void SetWorkShift(WorkShift newWorkShift)
      {
         if (this.workShift != newWorkShift)
         {
            if (this.workShift != null)
            {
               WorkShift oldWorkShift = this.workShift;
               this.workShift = null;
               oldWorkShift.RemoveWorkTime(this);
            }
            if (newWorkShift != null)
            {
               this.workShift = newWorkShift;
               this.workShift.AddWorkTime(this);
            }
         }
      }
   
      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }

        public WorkTime(WorkShift workShift, DateTime startTime, DateTime endTime)
        {
            this.workShift = workShift;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}