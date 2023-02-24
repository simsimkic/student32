/***********************************************************************
 * Module:  TemplateReportService.cs
 * Purpose: Definition of the Class Service.TemplateReportService
 ***********************************************************************/

using System;

namespace Service
{
   public abstract class TemplateReportService
   {
      public void CreateReport(Object obj, DateTime startDate, DateTime endDate)
      {
         // TODO: implement
      }
      
      public abstract void FillReport();
   
   }
}