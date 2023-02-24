/***********************************************************************
 * Module:  BlogController.cs
 * Purpose: Definition of the Class Controller.BlogController
 ***********************************************************************/

using Model.Doctor;
using Model.PatientSecretary;
using System;

namespace Controller
{
   public class BlogController
   {
      public Model.Doctor.Article PostArticleOnBlog(Model.Doctor.Article article)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteArticleFromBlog()
      {
         // TODO: implement
         return false;
      }
      
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
      
      public Article DeleteArticle(Article article)
      {
         // TODO: implement
         return null;
      }
      
      public Comment AddComment(Comment comment)
      {
         // TODO: implement
         return null;
      }
      
      public Comment DeleteComment(Comment comment)
      {
         // TODO: implement
         return null;
      }
      
      public BlogController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private BlogController()
      {
         // TODO: implement
      }
   
      public Service.BlogService blogService;
      public Service.ArticleService articleService;
      public Service.CommentService commentService;
   
      private static BlogController instance = null;

        public static BlogController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BlogController();
                }
                return instance;
            }
        }

   
   }
}