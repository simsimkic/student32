/***********************************************************************
 * Module:  Person.cs
 * Purpose: Definition of the Class Model.User.Person
 ***********************************************************************/

using System;
using static Model.User.Gender;

namespace Model.User
{
   public class Person
   {
      public Adress adress;
   
      public String FirstName { get; set; }
      public String LastName { get; set; }
      public String Jmbg { get; set; }
      public DateTime DateOfBirth { get; set; }
      public String PhoneNumber { get; set; }
      public String Email { get; set; }
      public GenderEnum Gender { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, string jmbg)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Jmbg = jmbg;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, string email, string jmbg, string address, string pass, GenderEnum gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Email = this.Email;
            this.Jmbg = jmbg;
            //nemamo polje za adresu
            this.Gender = gender;
               

        }

        public Person(Adress adress, string firstName, string lastName, string jmbg, DateTime dateOfBirth, string phoneNumber, string email, GenderEnum gender)
        {
            this.adress = adress;
            FirstName = firstName;
            LastName = lastName;
            Jmbg = jmbg;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Gender = gender;
        }
    }
}