/***********************************************************************
 * Module:  Blog.cs
 * Purpose: Definition of the Class Model.Doctor.Blog
 ***********************************************************************/

using System;
using System.Collections;

namespace Model.Doctor
{
   public class Blog
   {
      public System.Collections.ArrayList article;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetArticle()
      {
         if (article == null)
            article = new System.Collections.ArrayList();
         return article;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetArticle(System.Collections.ArrayList newArticle)
      {
         RemoveAllArticle();
         foreach (Article oArticle in newArticle)
            AddArticle(oArticle);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddArticle(Article newArticle)
      {
         if (newArticle == null)
            return;
         if (this.article == null)
            this.article = new System.Collections.ArrayList();
         if (!this.article.Contains(newArticle))
            this.article.Add(newArticle);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveArticle(Article oldArticle)
      {
         if (oldArticle == null)
            return;
         if (this.article != null)
            if (this.article.Contains(oldArticle))
               this.article.Remove(oldArticle);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllArticle()
      {
         if (article != null)
            article.Clear();
      }
   
      public String Title { get; set; }
      public String Content { get; set; }

        public Blog(ArrayList article, string title, string content)
        {
            this.article = article;
            Title = title;
            Content = content;
        }
    }
}