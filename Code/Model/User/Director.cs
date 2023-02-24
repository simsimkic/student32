/***********************************************************************
 * Module:  Director.cs
 * Purpose: Definition of the Class Model.User.Director
 ***********************************************************************/

using Model.Director;
using System;

namespace Model.User
{
   public class Director : User
   {
      public AnnualLeave[] annualLeave;

        public Director()
        {
        }
    }
}