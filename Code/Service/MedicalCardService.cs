/***********************************************************************
 * Module:  MedicalCardService.cs
 * Purpose: Definition of the Class Service.MedicalCardService
 ***********************************************************************/

using System;

namespace Service
{
   public class MedicalCardService
   {
      public Model.PatientSecretary.MedicalCard ReadMedicalCard(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.PatientSecretary.Allergen AddAllergen(Model.PatientSecretary.Allergen allergen, Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.PatientSecretary.Allergen EditAllergen(Model.PatientSecretary.Allergen allergen, Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.PatientSecretary.RiskFactor AddRiskFactor(Model.PatientSecretary.RiskFactor riskFactor, Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.PatientSecretary.RiskFactor EditRiskFactor(Model.PatientSecretary.RiskFactor riskFactor, Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public MedicalCardService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private MedicalCardService()
      {
         // TODO: implement
      }
   
      public Repository.MedicalCardRepository medicalCardRepository;
   
      private static MedicalCardService instance = null;

        public static MedicalCardService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalCardService();
                }
                return instance;
            }
        }

    }
}