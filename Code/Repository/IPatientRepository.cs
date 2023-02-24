/***********************************************************************
 * Module:  IPatientRepository.cs
 * Purpose: Definition of the Interface Repository.IPatientRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IPatientRepository : IRepository
   {
      Model.User.Patient GetPatientByJMBG(string jmbg);
   }
}