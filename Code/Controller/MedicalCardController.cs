/***********************************************************************
 * Module:  MedicalCardController.cs
 * Purpose: Definition of the Class Controller.MedicalCardController
 ***********************************************************************/

using System;

namespace Controller
{
   public class MedicalCardController
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
      
      public MedicalCardController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private MedicalCardController()
      {
         // TODO: implement
      }
   
      public Service.MedicalCardService medicalCardService;
   
      private static MedicalCardController instance=null;

        public static MedicalCardController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalCardController();
                }
                return instance;
            }
        }

    }
}