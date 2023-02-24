/***********************************************************************
 * Module:  ReportController.cs
 * Purpose: Definition of the Class Controller.ReportController
 ***********************************************************************/

using System;

namespace Controller
{
   public class ReportController
   {
      public void CreateReport(Object obj, DateTime startDate, DateTime endDate)
      {
         // TODO: implement
      }
   
      public Service.DirectorReportService directorReportService;
      public Service.DoctorReportService doctorReportService;
      public Service.PatientReportService patientReportService;
      public Service.SecretaryReportService secretaryReportService;
   
   }
}