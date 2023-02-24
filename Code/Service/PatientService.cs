/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService
 ***********************************************************************/

using Model.User;
using Repository;
using System;

namespace Service
{
   public class PatientService
   {
        private PatientRepository pr = new PatientRepository();
        public String GetMedicalHistory(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public PatientService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private PatientService()
      {
         // TODO: implement
      }
   
      public Repository.PatientRepository patientRepository;
   
      private static PatientService instance = null;

        public static PatientService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientService();
                }
                return instance;
            }
        }

        public Patient GetPatientByUsername(string username)
        {
           return pr.GetPatientByUsername(username);
        }

        public bool OpenFile()
        {
            return pr.OpenFile(null);
        }
    }
}