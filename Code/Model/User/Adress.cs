/***********************************************************************
 * Module:  Adress.cs
 * Purpose: Definition of the Class Model.User.Adress
 ***********************************************************************/

using System;

namespace Model.User
{
   public class Adress
   {
      public City city;
   
      public String Street { get; set; }
      public int Number { get; set; }

        public Adress(City city, string street, int number)
        {
            this.city = city;
            Street = street;
            Number = number;
        }
    }
}