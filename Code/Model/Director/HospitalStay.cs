/***********************************************************************
 * Module:  HospitalStay.cs
 * Purpose: Definition of the Class Model.Director.HospitalStay
 ***********************************************************************/

using Model.User;
using System;

namespace Model.Director
{
   public class HospitalStay
   {
      public Model.User.Doctor doctor { get; set; }
      public Model.User.Patient patient { get; set; }

      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }

        public HospitalStay(User.Doctor doctor, Patient patient, DateTime startTime, DateTime endTime)
        {
            this.doctor = doctor;
            this.patient = patient;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}