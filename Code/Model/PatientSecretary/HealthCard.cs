/***********************************************************************
 * Module:  HealthCard.cs
 * Purpose: Definition of the Class PatientSecretary.HealthCard
 ***********************************************************************/

using Model.User;
using System;

namespace Model.PatientSecretary
{
   public class HealthCard
   {
      public Model.User.Patient patient;
   
      public String NumHelathCard { get; set; }
      public String Lbo { get; set; }
      public DateTime DateIssue { get; set; }
      public Boolean IsValid { get; set; }

        public HealthCard(Patient patient, string numHelathCard, string lbo, DateTime dateIssue, bool isValid)
        {
            this.patient = patient;
            NumHelathCard = numHelathCard;
            Lbo = lbo;
            DateIssue = dateIssue;
            IsValid = isValid;
        }
    }
}