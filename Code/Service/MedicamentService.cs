/***********************************************************************
 * Module:  MedicamentService.cs
 * Purpose: Definition of the Class Service.MedicamentService
 ***********************************************************************/

using System;

namespace Service
{
   public class MedicamentService
   {
      public Model.Director.Medicament AddMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Director.Medicament EditMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean RemoveMedicament(Model.Director.Medicament medicament)
      {
         // TODO: implement
         return false;
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
      
      public MedicamentService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private MedicamentService()
      {
         // TODO: implement
      }
   
      public Repository.MedicamentRepository medicamentRepository;
   
      private static MedicamentService instance = null;

        public static MedicamentService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicamentService();
                }
                return instance;
            }
        }

    }
}