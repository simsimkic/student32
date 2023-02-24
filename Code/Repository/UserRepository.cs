/***********************************************************************
 * Module:  UserRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.User;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository
{
   public class UserRepository : IUserRepository
   {
      private String Path = @"\\Mac\Home\Desktop\Data\userRepo.txt";
        public static ObservableCollection<User> userList = new ObservableCollection<User>();

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

       

        public object Create(object obj)
        {
            User u = (User)obj;
            User u1 = new User(u.Username, u.Password, u.Role);
            foreach (User oneUser in userList)
            {
                
                if (u1.Username.Equals(oneUser.Username))
                {
                    return null;
                }
            }

            userList.Add(u1);
            Save();
            return u1;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public object Edit()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            return userList;
        }

        // popraviti da vraca objekat a ne boolean!!!
        public bool GetUserByUsernameAndPassword(string username, string password)
        {
 
            foreach (User oneUser in userList)
            {
                if(oneUser.Username.Equals(username) && oneUser.Password.Equals(password))
                {
                    
                    return true;
                }
            }
         
            return false;

        }

        public bool OpenFile(string path)
        {
            bool flag = true;

            if (File.Exists(Path) && new FileInfo(Path).Length != 0)
            {
                userList = JsonConvert.DeserializeObject<ObservableCollection<User>>(File.ReadAllText(Path));
            }
            else
            {
                flag = false;
                userList = new ObservableCollection<User>();
            }

            return flag;
        }

        public object Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(userList, Formatting.Indented));

            return null;
        }
    }
}