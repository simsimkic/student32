/***********************************************************************
 * Module:  DoctorController.cs
 * Purpose: Definition of the Class Controller.DoctorController
 ***********************************************************************/

using HospPatient.Models;
using Model.User;
using Service;
using System;
using System.Collections.ObjectModel;

namespace Controller
{
   public class DoctorController
   {
      public Model.Doctor.Specialization GetSpecialization(Model.Doctor.Specialization specialization)
      {
         // TODO: implement
         return null;
      }
      
      public DoctorController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DoctorController()
      {
         // TODO: implement
      }

        public bool OpenFile()
        {
            DoctorService ds = DoctorService.getInstance;

            return ds.OpenFile();
        }

        public ObservableCollection<Doctor> getAllDoctors()
        {

            return DoctorService.getInstance.getAllDoctors();
        }


        public Service.DoctorService doctorService;
   
      private static DoctorController instance=null;

        public static DoctorController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorController();
                }
                return instance;
            }
        }

    }
}