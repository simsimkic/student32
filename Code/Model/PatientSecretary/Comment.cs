/***********************************************************************
 * Module:  Comment.cs
 * Purpose: Definition of the Class Model.PatientSecretary.Comment
 ***********************************************************************/

using Model.User;
using System;

namespace Model.PatientSecretary
{
   public class Comment
   {
      public Model.User.Patient patient;
   
      public String Text { get; set; }
      public DateTime PublishingDate { get; set; }
      public int CommentID { get; set; }

        public Comment(Patient patient, string text, DateTime publishingDate, int commentID)
        {
            this.patient = patient;
            Text = text;
            PublishingDate = publishingDate;
            CommentID = commentID;
        }
    }
}