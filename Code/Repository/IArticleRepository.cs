/***********************************************************************
 * Module:  IArticleRepository.cs
 * Purpose: Definition of the Interface Repository.IArticleRepository
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Repository
{
   public interface IArticleRepository : IRepository
   {
      Article GetArticleById(int articleId);
   }
}