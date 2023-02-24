/***********************************************************************
 * Module:  IDirectorRepository.cs
 * Purpose: Definition of the Interface Repository.IDirectorRepository
 ***********************************************************************/

using Model.User;
using System;

namespace Repository
{
   public interface IDirectorRepository : IRepository
   {
      Director GetDirectorByUsername(String directorUsername);
   }
}