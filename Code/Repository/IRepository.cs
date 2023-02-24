/***********************************************************************
 * Module:  IRepository.cs
 * Purpose: Definition of the Interface Repository.IRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRepository
   {
      Object GetAll();
      Object Save();
      Boolean Delete();// delete from list and call Save
      Object Edit();
      Boolean OpenFile(String path);
      Boolean CloseFile(String path);
      Object Create(Object obj);
   }
}