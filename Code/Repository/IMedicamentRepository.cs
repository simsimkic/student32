/***********************************************************************
 * Module:  IMedicamentRepository.cs
 * Purpose: Definition of the Interface Repository.IMedicamentRepository
 ***********************************************************************/

using Model.Director;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface IMedicamentRepository : IRepository
   {
      Model.Director.Medicament GetMedicamentById(int medicamentId);
      Model.Director.Medicament GetMedicamentByName(String medicamentName);
      List<Medicament> GetAlternativeMedicaments(Model.Director.Medicament medicament);
      List<Medicament> GetApprovedMedicaments();
   }
}