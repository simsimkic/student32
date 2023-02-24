/***********************************************************************
 * Module:  StockroomController.cs
 * Purpose: Definition of the Class Controller.StockroomController
 ***********************************************************************/

using System;

namespace Controller
{
   public class StockroomController
   {
      public Model.Director.Equipment AddEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.Equipment EditEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteEquipment(Model.Director.Equipment equipment)
      {
         // TODO: implement
         return false;
      }
      
      public Model.Director.Medicament AddMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean RemoveMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return false;
      }
      
      public StockroomController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private StockroomController()
      {
         // TODO: implement
      }
   
      public Service.EquipmentService equipmentService;
      public Service.MedicamentService medicamentService;

        private static StockroomController instance = null;

        public static StockroomController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StockroomController();
                }
                return instance;
            }
        }

    }
}