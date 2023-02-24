/***********************************************************************
 * Module:  ReportService.cs
 * Purpose: Definition of the Class Service.DoctorServices.ReportService
 ***********************************************************************/

using System;

namespace Service
{
   public class DiagnosisService
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
      
      public DiagnosisService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DiagnosisService()
      {
         // TODO: implement
      }
   
      public Repository.DiagnosisRepository diagnosisRepository;
   
      private static DiagnosisService instance = null;

        public static DiagnosisService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DiagnosisService();
                }
                return instance;
            }
        }

    }
}