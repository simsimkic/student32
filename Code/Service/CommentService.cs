/***********************************************************************
 * Module:  CommentService.cs
 * Purpose: Definition of the Class Service.DoctorServices.CommentService
 ***********************************************************************/

using Model.PatientSecretary;
using System;

namespace Service
{
   public class CommentService
   {
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
      
      public CommentService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private CommentService()
      {
         // TODO: implement
      }
   
      public Repository.CommentRepository commentRepository;
   
      private static CommentService instance = null;

        public static CommentService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommentService();
                }
                return instance;
            }
        }
    }
}