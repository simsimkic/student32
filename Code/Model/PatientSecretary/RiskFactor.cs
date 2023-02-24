/***********************************************************************
 * Module:  RiskFactor.cs
 * Purpose: Definition of the Class Model.PatientSecretary.RiskFactor
 ***********************************************************************/

using System;

namespace Model.PatientSecretary
{
   public class RiskFactor
   {
      public String NameOfRisk { get; set; }
      public String Description { get; set; }

        public RiskFactor(string nameOfRisk, string description)
        {
            NameOfRisk = nameOfRisk;
            Description = description;
        }
    }
}