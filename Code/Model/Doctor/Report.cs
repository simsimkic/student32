/***********************************************************************
 * Module:  Report.cs
 * Purpose: Definition of the Class Model.Doctor.Report
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Report
   {
      public System.Collections.ArrayList diagnosis;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDiagnosis()
      {
         if (diagnosis == null)
            diagnosis = new System.Collections.ArrayList();
         return diagnosis;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDiagnosis(System.Collections.ArrayList newDiagnosis)
      {
         RemoveAllDiagnosis();
         foreach (Diagnosis oDiagnosis in newDiagnosis)
            AddDiagnosis(oDiagnosis);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDiagnosis(Diagnosis newDiagnosis)
      {
         if (newDiagnosis == null)
            return;
         if (this.diagnosis == null)
            this.diagnosis = new System.Collections.ArrayList();
         if (!this.diagnosis.Contains(newDiagnosis))
            this.diagnosis.Add(newDiagnosis);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDiagnosis(Diagnosis oldDiagnosis)
      {
         if (oldDiagnosis == null)
            return;
         if (this.diagnosis != null)
            if (this.diagnosis.Contains(oldDiagnosis))
               this.diagnosis.Remove(oldDiagnosis);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDiagnosis()
      {
         if (diagnosis != null)
            diagnosis.Clear();
      }
      public Examination examination;
   
      public int ReportID { get; set; }
      public String ReportDescription { get; set; }
      public DateTime ReportDate { get; set; }

        public Report(int reportID, string reportDescription, DateTime reportDate)
        {
            ReportID = reportID;
            ReportDescription = reportDescription;
            ReportDate = reportDate;
        }
    }
}