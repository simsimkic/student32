/***********************************************************************
 * Module:  BlogService.cs
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using System;

namespace Service
{
   public class BlogService
   {
      public Model.Doctor.Article PostArticleOnBlog(Model.Doctor.Article article)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteArticleFromBlog(Model.Doctor.Article article)
      {
         // TODO: implement
         return false;
      }
      
      public BlogService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private BlogService()
      {
         // TODO: implement
      }
   
      public Repository.ArticleRepository articleRepository;
      public Repository.CommentRepository commentRepository;
   
      private static BlogService instance = null;

        public static BlogService getInstance
        {
            get 
            { 
                if(instance == null)
                {
                    instance = new BlogService();
                }
                return instance;
            }

        } 
   
   }
}