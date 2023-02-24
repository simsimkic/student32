/***********************************************************************
 * Module:  Article.cs
 * Purpose: Definition of the Class Model.Doctor.Article
 ***********************************************************************/

using Model.PatientSecretary;
using System;

namespace Model.Doctor
{
   public class Article
   {
      public System.Collections.ArrayList comment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetComment()
      {
         if (comment == null)
            comment = new System.Collections.ArrayList();
         return comment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetComment(System.Collections.ArrayList newComment)
      {
         RemoveAllComment();
         foreach (Comment oComment in newComment)
            AddComment(oComment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddComment(Comment newComment)
      {
         if (newComment == null)
            return;
         if (this.comment == null)
            this.comment = new System.Collections.ArrayList();
         if (!this.comment.Contains(newComment))
            this.comment.Add(newComment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveComment(Comment oldComment)
      {
         if (oldComment == null)
            return;
         if (this.comment != null)
            if (this.comment.Contains(oldComment))
               this.comment.Remove(oldComment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllComment()
      {
         if (comment != null)
            comment.Clear();
      }
      public Model.User.Doctor doctor;
   
      public String Title { get; set; }
      public String Text { get; set; }
      public DateTime PublishingDate { get; set; }
      public Boolean IsPublished { get; set; }
      public int ArticleID { get; set; }

        public Article(string title, string text, DateTime publishingDate, bool isPublished, int articleID)
        {
            Title = title;
            Text = text;
            PublishingDate = publishingDate;
            IsPublished = isPublished;
            ArticleID = articleID;
        }
    }
}