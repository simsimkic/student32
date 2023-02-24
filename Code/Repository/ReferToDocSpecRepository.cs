/***********************************************************************
 * Module:  ReferToDocSpecRepository.cs
 * Purpose: Definition of the Class Repository.ReferToDocSpecRepository
 ***********************************************************************/

using Model.Doctor;
using Model.User;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class ReferToDocSpecRepository : IReferToDocSpecRepository
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

        public ReferToDocSpec GetReferByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<ReferToDocSpec> GetRefersByDocSpec(SpecialistDoctor docSpec)
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