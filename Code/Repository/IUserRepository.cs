/***********************************************************************
 * Module:  IUserRepository.cs
 * Purpose: Definition of the Interface Repository.IUserRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IUserRepository : IRepository
   {
      Boolean GetUserByUsernameAndPassword(String username, String password);
   }
}