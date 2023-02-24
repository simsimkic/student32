/***********************************************************************
 * Module:  SurveyRepository.cs
 * Purpose: Definition of the Class Repository.SurveyRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public class SurveyRepository : ISurveyRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public object Edit()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetSurveyById(int idSurvey)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Save()
        {
            throw new NotImplementedException();
        }
    }
}