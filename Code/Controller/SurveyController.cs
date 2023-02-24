/***********************************************************************
 * Module:  SurveyController.cs
 * Purpose: Definition of the Class Controller.SurveyController
 ***********************************************************************/

using System;

namespace Controller
{
   public class SurveyController
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
      
      public SurveyController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private SurveyController()
      {
         // TODO: implement
      }
   
      public Service.SurveyService surveyService;

        private static SurveyController instance = null;

        public static SurveyController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurveyController();
                }
                return instance;
            }
        }

    }
}