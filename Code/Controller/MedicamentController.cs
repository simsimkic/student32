/***********************************************************************
 * Module:  MedicamentController.cs
 * Purpose: Definition of the Class Controller.MedicamentController
 ***********************************************************************/

using System;

namespace Controller
{
   public class MedicamentController
   {
      public Model.Director.Medicament EditMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.Medicament SendMedicamentForApprove(Model.Director.Medicament medicament, Model.User.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.Medicament AddAlternativeMedicament(Model.Director.Medicament alternativeMedicament)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.Medicament ApproveMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return null;
      }
      
      public MedicamentController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private MedicamentController()
      {
         // TODO: implement
      }
   
      public Service.MedicamentService medicamentService;
   
      private static MedicamentController instance=null;

        public static MedicamentController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicamentController();
                }
                return instance;
            }
        }

    }
}