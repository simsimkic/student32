/***********************************************************************
 * Module:  RecipeRepository.cs
 * Purpose: Definition of the Class Repository.RecipeRepository
 ***********************************************************************/

using Model.Doctor;
using Model.User;
using System;

namespace Repository
{
   public class RecipeRepository : IRecipeRepository
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

        public Recipe GetRecipeById(int examinationID)
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipeByPatient(Patient patient)
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