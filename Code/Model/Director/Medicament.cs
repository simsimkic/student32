/***********************************************************************
 * Module:  Medicament.cs
 * Purpose: Definition of the Class Model.Director.Medicament
 ***********************************************************************/

using System;
using System.Collections;
using static Model.Director.MedicamentState;

namespace Model.Director
{
   public class Medicament
   {
      public System.Collections.ArrayList ingredient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetIngredient()
      {
         if (ingredient == null)
            ingredient = new System.Collections.ArrayList();
         return ingredient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetIngredient(System.Collections.ArrayList newIngredient)
      {
         RemoveAllIngredient();
         foreach (Ingredient oIngredient in newIngredient)
            AddIngredient(oIngredient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddIngredient(Ingredient newIngredient)
      {
         if (newIngredient == null)
            return;
         if (this.ingredient == null)
            this.ingredient = new System.Collections.ArrayList();
         if (!this.ingredient.Contains(newIngredient))
            this.ingredient.Add(newIngredient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveIngredient(Ingredient oldIngredient)
      {
         if (oldIngredient == null)
            return;
         if (this.ingredient != null)
            if (this.ingredient.Contains(oldIngredient))
               this.ingredient.Remove(oldIngredient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllIngredient()
      {
         if (ingredient != null)
            ingredient.Clear();
      }
      public System.Collections.ArrayList alternativeMedicament;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAlternativeMedicament()
      {
         if (alternativeMedicament == null)
            alternativeMedicament = new System.Collections.ArrayList();
         return alternativeMedicament;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAlternativeMedicament(System.Collections.ArrayList newAlternativeMedicament)
      {
         RemoveAllAlternativeMedicament();
         foreach (Model.Director.Medicament oMedicament in newAlternativeMedicament)
            AddAlternativeMedicament(oMedicament);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAlternativeMedicament(Model.Director.Medicament newMedicament)
      {
         if (newMedicament == null)
            return;
         if (this.alternativeMedicament == null)
            this.alternativeMedicament = new System.Collections.ArrayList();
         if (!this.alternativeMedicament.Contains(newMedicament))
            this.alternativeMedicament.Add(newMedicament);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAlternativeMedicament(Model.Director.Medicament oldMedicament)
      {
         if (oldMedicament == null)
            return;
         if (this.alternativeMedicament != null)
            if (this.alternativeMedicament.Contains(oldMedicament))
               this.alternativeMedicament.Remove(oldMedicament);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAlternativeMedicament()
      {
         if (alternativeMedicament != null)
            alternativeMedicament.Clear();
      }
      public Model.User.Doctor doctor { get; set; }
      public Model.User.Director director { get; set; }

      public int MedicamentId { get; set; }
      public String Name { get; set; }
      public DateTime ExpDate { get; set; }
      public int Amount { get; set; }
      public MedicamentStateEnum ApprovingState { get; set; }

        public Medicament(ArrayList ingredient, ArrayList alternativeMedicament, User.Doctor doctor, User.Director director, int medicamentId, string name, DateTime expDate, int amount, MedicamentStateEnum approvingState)
        {
            this.ingredient = ingredient;
            this.alternativeMedicament = alternativeMedicament;
            this.doctor = doctor;
            this.director = director;
            MedicamentId = medicamentId;
            Name = name;
            ExpDate = expDate;
            Amount = amount;
            ApprovingState = approvingState;
        }
    }
}