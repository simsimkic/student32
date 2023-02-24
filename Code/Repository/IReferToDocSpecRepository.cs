/***********************************************************************
 * Module:  IReferToDocSpecRepository.cs
 * Purpose: Definition of the Interface Repository.IReferToDocSpecRepository
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface IReferToDocSpecRepository : IRepository
   {
      Model.Doctor.ReferToDocSpec GetReferByPatient(Model.User.Patient patient);
      List<ReferToDocSpec> GetRefersByDocSpec(Model.Doctor.SpecialistDoctor docSpec);
   }
}