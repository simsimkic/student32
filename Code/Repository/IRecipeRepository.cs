/***********************************************************************
 * Module:  IRecipeRepository.cs
 * Purpose: Definition of the Interface Repository.IRecipeRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRecipeRepository : IRepository
   {
      Model.Doctor.Recipe GetRecipeByPatient(Model.User.Patient patient);
      Model.Doctor.Recipe GetRecipeById(int examinationID);
   }
}