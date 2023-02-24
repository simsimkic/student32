/***********************************************************************
 * Module:  RecipeController.cs
 * Purpose: Definition of the Class Controller.RecipeController
 ***********************************************************************/

using System;

namespace Controller
{
   public class RecipeController
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
      
      public RecipeController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private RecipeController()
      {
         // TODO: implement
      }
   
      public Service.RecipeService recipeService;

        private static RecipeController instance = null;

        public static RecipeController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeController();
                }
                return instance;
            }
        }

    }
}