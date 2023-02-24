/***********************************************************************
 * Module:  IHospitalStayRepository.cs
 * Purpose: Definition of the Interface Repository.IHospitalStayRepository
 ***********************************************************************/

using Model.Director;
using System;

namespace Repository
{
   public interface IHospitalStayRepository : IRepository
   {
      HospitalStay GetHospitalStayByPatient(Model.User.Patient patient);
      HospitalStay GetHospitalStayByRoomId(int roomId);
   }
}