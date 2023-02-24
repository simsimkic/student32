/***********************************************************************
 * Module:  ArticleService.cs
 * Purpose: Definition of the Class Service.DoctorServices.ArticleService
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Service
{
    public class ArticleService
    {
        public Article CreateArticle(Article article)
        {
            // TODO: implement
            return null;
        }

        public Article ReadArticle(Article article)
        {
            // TODO: implement
            return null;
        }

        public Article EditArticle(Article article)
        {
            // TODO: implement
            return null;
        }

        public Boolean DeleteArticle(Article article)
        {
            // TODO: implement
            return false;
        }

        public ArticleService GetInstance()
        {
            // TODO: implement
            return null;
        }

        private ArticleService()
        {
            // TODO: implement
        }

        public Repository.ArticleRepository articleRepository;

        private static ArticleService instance = null;

        public static ArticleService getInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ArticleService();
                }
                return instance;
            }
        }
   
   }
}