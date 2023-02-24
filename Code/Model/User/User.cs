/***********************************************************************
 * Module:  User.cs
 * Purpose: Definition of the Class Model.User.User
 ***********************************************************************/

using System;
using static Model.User.Gender;
using static Model.User.Role;

namespace Model.User
{
   public class User : Person
   {
      public Notification[] notification;
   
      public String Username { get; set; }
      public String Password { get; set; }
      public RoleEnum Role { get; set; }


        public User()
        {

        }

        public User(string firstName, string lastName, string jmbg) : base(firstName, lastName, jmbg) { }
                                                                                                                                                        //napraviti ovakav konstruktor u klasi Person
        public User(string firstName, string lastName, DateTime dateOfBirth, string email, string jmbg, string address,  string pass, GenderEnum gender, RoleEnum role) : base(firstName, lastName, dateOfBirth ,email, jmbg, address, pass, gender) {
            this.Username = email;
            this.Password = pass;
            this.Role = role; 
        }

        public User(string username, string password, RoleEnum role, Person person)
        {
            
        }



        public User(string username, string password, RoleEnum role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}