/***********************************************************************
 * Module:  RecipeService.cs
 * Purpose: Definition of the Class Service.RecipeService
 ***********************************************************************/

using System;

namespace Service
{
   public class RecipeService
   {
      public Model.Doctor.Recipe CreateRecipe(Model.Doctor.Recipe recipe)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Recipe EditRecipe(Model.Doctor.Recipe recipe)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteRecipe(Model.Doctor.Recipe recipe)
      {
         // TODO: implement
         return false;
      }
      
      public RecipeService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private RecipeService()
      {
         // TODO: implement
      }
   
      public Repository.RecipeRepository recipeRepository;
   
      private static RecipeService instance = null;

        public static RecipeService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeService();
                }
                return instance;
            }
        }

    }
}