/***********************************************************************
 * Module:  Ingredient.cs
 * Purpose: Definition of the Class Model.Director.Ingredient
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class Ingredient
   {
      public String Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}