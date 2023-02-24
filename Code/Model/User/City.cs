/***********************************************************************
 * Module:  City.cs
 * Purpose: Definition of the Class Model.User.City
 ***********************************************************************/

using System;

namespace Model.User
{
   public class City
   {
      public Country country;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Country GetCountry()
      {
         return country;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newCountry</param>
      public void SetCountry(Country newCountry)
      {
         if (this.country != newCountry)
         {
            if (this.country != null)
            {
               Country oldCountry = this.country;
               this.country = null;
               oldCountry.RemoveCity(this);
            }
            if (newCountry != null)
            {
               this.country = newCountry;
               this.country.AddCity(this);
            }
         }
      }
   
      public String NameOfCity { get; set; }
      public int PostalCode { get; set; }

        public City(Country country, string nameOfCity, int postalCode)
        {
            this.country = country;
            NameOfCity = nameOfCity;
            PostalCode = postalCode;
        }
    }
}