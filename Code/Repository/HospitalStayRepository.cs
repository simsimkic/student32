/***********************************************************************
 * Module:  HospitalStayRepository.cs
 * Purpose: Definition of the Class Repository.HospitalStayRepository
 ***********************************************************************/

using Model.Director;
using Model.User;
using System;

namespace Repository
{
   public class HospitalStayRepository : IHospitalStayRepository
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

        public HospitalStay GetHospitalStayByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public HospitalStay GetHospitalStayByRoomId(int roomId)
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