/***********************************************************************
 * Module:  ISurgeryRepository.cs
 * Purpose: Definition of the Interface Repository.ISurgeryRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface ISurgeryRepository : IRepository
   {
      Model.Doctor.Surgery GetSurgeryByPatient(Model.User.Patient patient);
      Model.Doctor.Surgery GetSurgeryByDoctor(Model.User.Doctor doctor);
      Model.Doctor.Surgery GetSurgeryById(int examinationID);
   }
}