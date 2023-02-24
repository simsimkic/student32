/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.DoctorServices.DoctorService
 ***********************************************************************/

using Model.User;
using Repository;
using System;
using System.Collections.ObjectModel;

namespace Service
{
   public class DoctorService
   {
      public Model.Doctor.Specialization GetSpecialization(Model.Doctor.Specialization specialization)
      {
         // TODO: implement
         return null;
      }
      
      public DoctorService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private DoctorService()
      {
         // TODO: implement
      }
   
      public Repository.DoctorRepository doctorRepository;
   
      private static DoctorService instance = null;

        public static DoctorService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorService();
                }
                return instance;
            }
        }

        public ObservableCollection<Doctor> getAllDoctors()
        {
            return DoctorRepository.doctorList;

        }

        public bool OpenFile()
        {
            DoctorRepository dr = new DoctorRepository();
            return dr.OpenFile(null);
        }
    }
}