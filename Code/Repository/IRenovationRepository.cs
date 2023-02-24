/***********************************************************************
 * Module:  IRenovationRepository.cs
 * Purpose: Definition of the Interface Repository.IRenovationRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRenovationRepository : IRepository
   {
      Model.Director.Renovation GetRenovationById(int renovationId);
   }
}