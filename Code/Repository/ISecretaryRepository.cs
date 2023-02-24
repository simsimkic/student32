/***********************************************************************
 * Module:  ISecretaryRepository.cs
 * Purpose: Definition of the Interface Repository.ISecretaryRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface ISecretaryRepository : IRepository
   {
      Model.PatientSecretary.Secretary GetSecretaryByUsername(String secretaryUsername);
   }
}