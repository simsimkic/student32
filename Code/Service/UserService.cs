/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserServices.UserService
 ***********************************************************************/

using Model.User;
using Repository;
using System;

namespace Service
{
   public class UserService
   {
        public User LoginUser(String username, String password)
        {


            bool retVal = userRepository.GetUserByUsernameAndPassword(username, password);


            //PRIVREMENO, SAMO ZA TESTIRANJE LOGOVANJA, TREBA VRATITI PRAVI OBJEKAT
            if (retVal)
            {
                Console.WriteLine("PROSAO SERVIS");

                foreach (User oneUser in UserRepository.userList)
                {
                    if (oneUser.Username.Equals(username))
                    {
                        return oneUser;
                    }
                }
            }

            Console.WriteLine("NIJE PROSAO SERVIS");
            return null;
        }
      
      public Boolean LogoutUser(User user)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsPasswordValid(String password)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsUsernameValid(String username)
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

        public bool OpenFile()
        {

            UserRepository ur = new UserRepository();
            return ur.OpenFile(null);
        }


        public Object RegisterUser(Object user)
      {
            // TODO: implement

            User u = (User)user;

            User uTemp=(User)userRepository.Create(u);

            if (uTemp == null)
                return null; //ako pacijent vec postoji
            //if user.role==Patient save to patientList


            Console.WriteLine(u.Role.ToString());
            

            if(u.Role == Role.RoleEnum.PATIENT)
            {
                Patient p = (Patient)user;
                PatientRepository pr = new PatientRepository();
                pr.Create(p);
                return p;
            }
            else if(u.Role == Role.RoleEnum.DOCTOR)
            {

                Console.WriteLine("DOSLI SMO DO ROLE DOCTOR");
                Doctor d = (Doctor)user;
                DoctorRepository dr = new DoctorRepository();
                dr.Create(d);
                return d;

            }

         
         return null;
      }
      
      public UserService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private UserService()
      {
         // TODO: implement
      }
   
      public Repository.UserRepository userRepository=new UserRepository();
   
      private static UserService instance = null;

        public static UserService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserService();
                }
                return instance;
            }
        }

    }
}