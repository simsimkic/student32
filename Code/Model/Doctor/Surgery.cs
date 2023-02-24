/***********************************************************************
 * Module:  Surgery.cs
 * Purpose: Definition of the Class Model.Doctor.Surgery
 ***********************************************************************/

using Model.User;
using System;

namespace Model.Doctor
{
   public class Surgery : MedicalService
   {
      public Model.User.Patient patient;
      public SpecialistDoctor specialistDoctor;

        public Surgery(Patient patient, SpecialistDoctor specialistDoctor)
        {
            this.patient = patient;
            this.specialistDoctor = specialistDoctor;
        }


    }
}