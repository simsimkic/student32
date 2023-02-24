/***********************************************************************
 * Module:  PatientController.cs
 * Purpose: Definition of the Class Controller.PatientController
 ***********************************************************************/

using Model.User;
using Service;
using System;

namespace Controller
{
   public class PatientController
   {
      public String GetMedicalHistory(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public PatientController GetInstance()
      {
         // TODO: implement
         return null;
      }
   


      private PatientController()
      {
         // TODO: implement
      }

        public Patient GetPatientByUsername(string username)
        {
            return PatientService.getInstance.GetPatientByUsername(username);
        }


        public bool OpenFile()
        {
            PatientService ps = PatientService.getInstance;

            return ps.OpenFile();
        }


        public Service.PatientService patientService;

        private static PatientController instance = null;

        public static PatientController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientController();
                }
                return instance;
            }
        }

    }
}