/***********************************************************************
 * Module:  AnnualLeave.cs
 * Purpose: Definition of the Class Model.Director.AnnualLeave
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class AnnualLeave
   {
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public Boolean Approved { get; set; }

        public AnnualLeave(DateTime startDate, DateTime endDate, bool approved)
        {
            StartDate = startDate;
            EndDate = endDate;
            Approved = approved;
        }
    }
}