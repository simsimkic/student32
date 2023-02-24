/***********************************************************************
 * Module:  IDiagnosisRepository.cs
 * Purpose: Definition of the Interface Repository.IDiagnosisRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IDiagnosisRepository : IRepository
   {
      Model.Doctor.Diagnosis GetDiagnosisByPatient(Model.User.Patient patient);
      Model.Doctor.Diagnosis GetDiagnosisById(int examinationID);
   }
}