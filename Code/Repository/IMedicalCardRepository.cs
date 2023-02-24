/***********************************************************************
 * Module:  IMedicalCardRepository.cs
 * Purpose: Definition of the Interface Repository.IMedicalCardRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IMedicalCardRepository : IRepository
   {
      int GetMedicalCardByJMBG(String patientJMBG);
   }
}