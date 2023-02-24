/***********************************************************************
 * Module:  RecipeItem.cs
 * Purpose: Definition of the Class Model.Doctor.RecipeItem
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class RecipeItem
   {
      public Model.Director.Medicament medicament;
   
      public int Amount { get; set; }
      public int Dose { get; set; }

        public RecipeItem(int amount, int dose)
        {
            Amount = amount;
            Dose = dose;
        }
    }
}