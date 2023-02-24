/***********************************************************************
 * Module:  SurveyService.cs
 * Purpose: Definition of the Class Service.SurveyService
 ***********************************************************************/

using System;

namespace Service
{
   public class SurveyService
   {
      public Model.PatientSecretary.Survey CreateSurvey(Model.PatientSecretary.Survey survey)
      {
         // TODO: implement
         return null;
      }
      
      public Model.PatientSecretary.Survey EditSurvey(Model.PatientSecretary.Survey survey)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteSurvey(Model.PatientSecretary.Survey survey)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean CompleteSurvey(Model.PatientSecretary.Survey survey)
      {
         // TODO: implement
         return false;
      }
      
      public SurveyService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SurveyService()
      {
         // TODO: implement
      }
   
      public Repository.SurveyRepository surveyRepository;
   
      private static SurveyService instance = null;

        public static SurveyService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurveyService();
                }
                return instance;
            }
        }

    }
}