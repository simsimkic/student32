/***********************************************************************
 * Module:  Recipe.cs
 * Purpose: Definition of the Class Model.Doctor.Recipe
 ***********************************************************************/

using Model.User;
using System;
using System.Collections;

namespace Model.Doctor
{
   public class Recipe
   {
      public System.Collections.ArrayList recipeItem;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecipeItem()
      {
         if (recipeItem == null)
            recipeItem = new System.Collections.ArrayList();
         return recipeItem;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecipeItem(System.Collections.ArrayList newRecipeItem)
      {
         RemoveAllRecipeItem();
         foreach (RecipeItem oRecipeItem in newRecipeItem)
            AddRecipeItem(oRecipeItem);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecipeItem(RecipeItem newRecipeItem)
      {
         if (newRecipeItem == null)
            return;
         if (this.recipeItem == null)
            this.recipeItem = new System.Collections.ArrayList();
         if (!this.recipeItem.Contains(newRecipeItem))
            this.recipeItem.Add(newRecipeItem);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecipeItem(RecipeItem oldRecipeItem)
      {
         if (oldRecipeItem == null)
            return;
         if (this.recipeItem != null)
            if (this.recipeItem.Contains(oldRecipeItem))
               this.recipeItem.Remove(oldRecipeItem);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecipeItem()
      {
         if (recipeItem != null)
            recipeItem.Clear();
      }
      public Model.User.Patient patient;
      public Model.User.Doctor doctor;
   
      public DateTime DateOfIssue { get; set; }
      public int RecipeID { get; set; }

        public Recipe(Patient patient, User.Doctor doctor, DateTime dateOfIssue, int recipeID)
        {
            this.patient = patient;
            this.doctor = doctor;
            DateOfIssue = dateOfIssue;
            RecipeID = recipeID;
        }
    }
}