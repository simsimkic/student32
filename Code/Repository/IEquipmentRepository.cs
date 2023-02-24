/***********************************************************************
 * Module:  IEquipmentRepository.cs
 * Purpose: Definition of the Interface Repository.IEquipmentRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IEquipmentRepository : IRepository
   {
      Model.Director.Equipment GetEquipmentById(int equipmentId);
   }
}