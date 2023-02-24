/***********************************************************************
 * Module:  ISurveyRepository.cs
 * Purpose: Definition of the Interface Repository.ISurveyRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface ISurveyRepository : IRepository
   {
      int GetSurveyById(int idSurvey);
   }
}