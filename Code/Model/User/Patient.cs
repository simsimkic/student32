/***********************************************************************
 * Module:  Patient.cs
 * Purpose: Definition of the Class Model.User.Patient
 ***********************************************************************/

using Model.Doctor;
using Model.PatientSecretary;
using System;
using System.Collections.ObjectModel;
using static Model.User.Gender;
using static Model.User.Role;

namespace Model.User
{
   public class Patient : User
   {
      public MedicalCard medicalCard;
      public HealthCard healthCard;
      public ReferToDocSpec[] referToDocSpec;
      public Survey[] survey;
        public string fullNamePatient { get; set; }

        public Boolean GuestUser { get; set; }

        public Patient()
        {

        }

        public Patient(string firstName, string lastName, DateTime dateOfBirth, string email, string jmbg, string address, string pass, GenderEnum gender, RoleEnum role) : base(firstName, lastName, dateOfBirth, email, jmbg, address, pass, gender, role) 
        {
            this.fullNamePatient = firstName + " " + lastName;
        }

        public Patient(string firstName, string lastName, string jmbg) : base(firstName, lastName, jmbg)
        {

        }


       public Patient(MedicalCard medicalCard, HealthCard healthCard, bool guestUser, User user){
            
        
        }

        public Patient(MedicalCard medicalCard, HealthCard healthCard, bool guestUser)
        {
        
            this.medicalCard = medicalCard;
            this.healthCard = healthCard;
            GuestUser = guestUser;
        }
    }
}