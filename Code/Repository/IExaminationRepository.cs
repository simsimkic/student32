/***********************************************************************
 * Module:  IExaminationRepository.cs
 * Purpose: Definition of the Interface Repository.IExaminationRepository
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface IExaminationRepository : IRepository
   {
      List<Examination> GetExaminationsByPatient(Model.User.Patient patient);
      List<Examination> GetExaminationsByDoctor(Model.User.Doctor doctor);
      Model.Doctor.Examination GetExaminationById(int examinationID);
   }
}