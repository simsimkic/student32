/***********************************************************************
 * Module:  Diagnosis.cs
 * Purpose: Definition of the Class Model.Doctor.Diagnosis
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Diagnosis
   {
      public Report[] report;
   
      public String NameOfDiagn { get; set; }
      public String DescriptionOfDiagn { get; set; }
      public int DiagnosisID { get; set; }

        public Diagnosis(string nameOfDiagn, string descriptionOfDiagn, int diagnosisID)
        {
            NameOfDiagn = nameOfDiagn;
            DescriptionOfDiagn = descriptionOfDiagn;
            DiagnosisID = diagnosisID;
        }
    }
}