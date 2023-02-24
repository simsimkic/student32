/***********************************************************************
 * Module:  MedicamentRepository.cs
 * Purpose: Definition of the Class Repository.MedicamentRepository
 ***********************************************************************/

using Model.Director;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class MedicamentRepository : IMedicamentRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public object Edit()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Medicament> GetAlternativeMedicaments(Medicament medicament)
        {
            throw new NotImplementedException();
        }

        public List<Medicament> GetApprovedMedicaments()
        {
            throw new NotImplementedException();
        }

        public Medicament GetMedicamentById(int medicamentId)
        {
            throw new NotImplementedException();
        }

        public Medicament GetMedicamentByName(string medicamentName)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Save()
        {
            throw new NotImplementedException();
        }
    }
}