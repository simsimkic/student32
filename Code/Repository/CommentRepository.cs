/***********************************************************************
 * Module:  Class3.cs
 * Purpose: Definition of the Class Repository.Class3
 ***********************************************************************/

using Model.PatientSecretary;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class CommentRepository : ICommentRepository
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

        public List<Comment> GetAllByArticleId(int articleId)
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