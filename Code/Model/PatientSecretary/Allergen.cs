/***********************************************************************
 * Module:  Allergen.cs
 * Purpose: Definition of the Class Model.PatientSecretary.Allergen
 ***********************************************************************/

using System;

namespace Model.PatientSecretary
{
   public class Allergen
   {
      public String Name { get; set; }

        public Allergen(string name)
        {
            Name = name;
        }
    }
}