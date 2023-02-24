/***********************************************************************
 * Module:  Question.cs
 * Purpose: Definition of the Class Model.PatientSecretary.Question
 ***********************************************************************/

using System;

namespace Model.PatientSecretary
{
   public class Question
   {
      public String Text { get; set; }
      public int Grade { get; set; }

        public Question(string text, int grade)
        {
            Text = text;
            Grade = grade;
        }
    }
}