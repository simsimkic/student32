/***********************************************************************
 * Module:  Equipment.cs
 * Purpose: Definition of the Class Model.Director.Equipment
 ***********************************************************************/

using System;
using static Model.Director.EquipmentType;

namespace Model.Director
{
   public class Equipment
   {
      public String EquipmentName { get; set; }
      public int Amount { get; set; }
      public EquipmentTypeEnum EquipmentType { get; set; }
      public int EquipmentId { get; set; }

        public Equipment(string equipmentName, int amount, EquipmentTypeEnum equipmentType, int equipmentId)
        {
            EquipmentName = equipmentName;
            Amount = amount;
            EquipmentType = equipmentType;
            EquipmentId = equipmentId;
        }
    }
}