/***********************************************************************
 * Module:  IRoomRepository.cs
 * Purpose: Definition of the Interface Repository.IRoomRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRoomRepository : IRepository
   {
      int GetRoomById();
   }
}