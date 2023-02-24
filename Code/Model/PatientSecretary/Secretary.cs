/***********************************************************************
 * Module:  Secretary.cs
 * Purpose: Definition of the Class User.Secretary
 ***********************************************************************/

using Model.Director;
using System;

namespace Model.PatientSecretary
{
   public class Secretary : Model.User.User
   {
      public WorkTime workTime;
      public AnnualLeave[] annualLeave;

        public Secretary(WorkTime workTime)
        {
            this.workTime = workTime;
        }
    }
}