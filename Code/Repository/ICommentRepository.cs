/***********************************************************************
 * Module:  ICommentRepository.cs
 * Purpose: Definition of the Interface Repository.ICommentRepository
 ***********************************************************************/

using Model.PatientSecretary;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface ICommentRepository : IRepository
   {
      List<Comment> GetAllByArticleId(int articleId);
   }
}