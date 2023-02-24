/***********************************************************************
 * Module:  SurgeryRepository.cs
 * Purpose: Definition of the Class Repository.SurgeryRepository
 ***********************************************************************/

using Model.Doctor;
using Model.User;
using System;

namespace Repository
{
   public class SurgeryRepository : ISurgeryRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public object Edit()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public Surgery GetSurgeryByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Surgery GetSurgeryById(int examinationID)
        {
            throw new NotImplementedException();
        }

        public Surgery GetSurgeryByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Save()
        {
            throw new NotImplementedException();
        }
    }
}