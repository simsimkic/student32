/***********************************************************************
 * Module:  DiagnosisController.cs
 * Purpose: Definition of the Class Controller.DiagnosisController
 ***********************************************************************/

using System;

namespace Controller
{
   public class DiagnosisController
   {
      public Model.Doctor.Diagnosis CreateDiagnosis(Model.Doctor.Diagnosis diagnosis)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Diagnosis DeleteDiagnosis(Model.Doctor.Diagnosis diagnosis)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Diagnosis EditDiagnosis(Model.Doctor.Diagnosis diagnosis)
      {
         // TODO: implement
         return null;
      }
      
      public DiagnosisController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DiagnosisController()
      {
         // TODO: implement
      }
   
      public Service.DiagnosisService diagnosisService;
   
      private static DiagnosisController instance=null;

        public static DiagnosisController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DiagnosisController();
                }
                return instance;
            }
        }

    }
}