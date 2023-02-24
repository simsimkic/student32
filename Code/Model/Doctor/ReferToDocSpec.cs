/***********************************************************************
 * Module:  ReferToDocSpec.cs
 * Purpose: Definition of the Class Model.Doctor.ReferToDocSpec
 ***********************************************************************/

using Model.User;
using System;

namespace Model.Doctor
{
   public class ReferToDocSpec
   {
      public Model.User.Patient patient;
      public Model.User.Doctor doctor;
      public SpecialistDoctor specialistDoctor;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public SpecialistDoctor GetSpecialistDoctor()
      {
         return specialistDoctor;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newSpecialistDoctor</param>
      public void SetSpecialistDoctor(SpecialistDoctor newSpecialistDoctor)
      {
         if (this.specialistDoctor != newSpecialistDoctor)
         {
            if (this.specialistDoctor != null)
            {
               SpecialistDoctor oldSpecialistDoctor = this.specialistDoctor;
               this.specialistDoctor = null;
               oldSpecialistDoctor.RemoveReferToDocSpec(this);
            }
            if (newSpecialistDoctor != null)
            {
               this.specialistDoctor = newSpecialistDoctor;
               this.specialistDoctor.AddReferToDocSpec(this);
            }
         }
      }
   
      public String ReasonDescription { get; set; }
      public int ReferID { get; set; }

        public ReferToDocSpec(Patient patient, User.Doctor doctor, SpecialistDoctor specialistDoctor, string reasonDescription, int referID)
        {
            this.patient = patient;
            this.doctor = doctor;
            this.specialistDoctor = specialistDoctor;
            ReasonDescription = reasonDescription;
            ReferID = referID;
        }
    }
}