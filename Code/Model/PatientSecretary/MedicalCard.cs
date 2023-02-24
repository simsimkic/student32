/***********************************************************************
 * Module:  MedicalCard.cs
 * Purpose: Definition of the Class Model.PatientSecretary.MedicalCard
 ***********************************************************************/

using Model.User;
using System;
using static Model.PatientSecretary.BloodGroup;
using static Model.PatientSecretary.RhFactor;

namespace Model.PatientSecretary
{
   public class MedicalCard
   {
      public Model.User.Patient patient;
      public RiskFactor[] riskFactor;
      public Allergen[] allergen;
   
      public String NumCard { get; set; }
      public BloodGroupEnum BloodGroup { get; set; }
      public RhFactorEnum RhFactor { get; set; }

        public MedicalCard(Patient patient, RiskFactor[] riskFactor, Allergen[] allergen, string numCard, BloodGroupEnum bloodGroup, RhFactorEnum rhFactor)
        {
            this.patient = patient;
            this.riskFactor = riskFactor;
            this.allergen = allergen;
            NumCard = numCard;
            BloodGroup = bloodGroup;
            RhFactor = rhFactor;
        }
    }
}