/***********************************************************************
 * Module:  EquipmentService.cs
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using System;

namespace Service
{
   public class EquipmentService
   {
      public Model.Director.Equipment AddEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return false;
      }
      
      public Model.Director.Equipment EditEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public EquipmentService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private EquipmentService()
      {
         // TODO: implement
      }
   
      public Repository.EquipmentRepository equipmentRepository;
   
      private static EquipmentService instance = null;

        public static EquipmentService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EquipmentService();
                }
                return instance;
            }
        }

    }
}