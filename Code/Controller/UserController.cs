/***********************************************************************
 * Module:  UserController.cs
 * Purpose: Definition of the Class Controller.UserController
 ***********************************************************************/

using Model.User;
using Service;
using System;

namespace Controller
{
   public class UserController
   {
      public User LoginUser(String username, String password)
      {
           User u= userService.LoginUser(username, password);
            //if(u==null)
              //  Console.WriteLine("NIJE PROSAO KONTROLER");
         return u;
      }
      
      public Boolean LogoutUser(User user)
      {
         // TODO: implement
         return false;
      }
      
      public User EditUserData(User user)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeactivateUser(User user)
      {
         // TODO: implement
         return false;
      }
      
      public User RegisterUser(Object user)
      {

            return (User)userService.RegisterUser(user);
            
      }
     
      public bool OpenFile()
        {
            UserService us = UserService.getInstance;

            return us.OpenFile();
        }

      public UserController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private UserController()
      {
            // TODO: implement
            
      }

        public Service.UserService userService = UserService.getInstance;

        private static UserController instance = null;

        public static UserController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserController();
                }
                return instance;
            }
        }

    }
}