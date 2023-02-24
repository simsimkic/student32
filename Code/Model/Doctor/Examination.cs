/***********************************************************************
 * Module:  Examination.cs
 * Purpose: Definition of the Class Patient.Examination
 ***********************************************************************/

using Model.User;
using System;

namespace Model.Doctor
{
   public class Examination : MedicalService
   {
      public Report report;
      public Recipe recipe;
      public ReferToDocSpec[] referToDocSpec;
      public Model.User.Doctor doctor { get; set; }
      public Model.User.Patient patient { get; set; }
      public string date { get; set; }
      public string time { get; set; }
   
      public int ExaminationID { get; set; }

        public Examination(User.Doctor doctor, Patient patient, int examinationID, string date, string time)
        {

            this.date = date;
            this.time = time;
            this.doctor = doctor;
            this.patient = patient;
            ExaminationID = examinationID;
        }
    }
}