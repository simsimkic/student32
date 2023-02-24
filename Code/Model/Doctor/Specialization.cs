/***********************************************************************
 * Module:  Specialization.cs
 * Purpose: Definition of the Class Model.Doctor.Specialization
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Specialization
   {
      public SpecialistDoctor[] specialistDoctor;
   
      public int SpecilazitionID { get; set; }
      public String NameOfSpec { get; set; }

        public Specialization(int specilazitionID, string nameOfSpec)
        {
            SpecilazitionID = specilazitionID;
            NameOfSpec = nameOfSpec;
        }
    }
}