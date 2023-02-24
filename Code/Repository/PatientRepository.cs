/***********************************************************************
 * Module:  PatientRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository
 ***********************************************************************/

using Model.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository
{
   public class PatientRepository : IPatientRepository
   {
        public static ObservableCollection<Patient> patientList = new ObservableCollection<Patient>();
      private String Path= @"\\Mac\Home\Desktop\Data\patientRepo.txt";

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            Patient p = (Patient)obj;

            patientList.Add(p);
            Save();
            return p;

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
            throw new NotImplementedException();
        }

        public Patient GetPatientByJMBG() 
        {
            throw new NotImplementedException();
        }

        
        
        public Patient GetPatientByUsername(string username)
        {
            
            foreach(Patient p in patientList)
            {
                Console.WriteLine();
                if (p.Username.Equals(username))
                {
                    return p;
                }
            }
            return null;
        }


        public Patient GetPatientByJMBG(string jmbg)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            //throw new NotImplementedException();
            bool flag = true;

            if (File.Exists(Path) && new FileInfo(Path).Length != 0)
            {
                patientList = JsonConvert.DeserializeObject<ObservableCollection<Patient>>(File.ReadAllText(Path));
            }
            else
            {
                flag = false;
                patientList = new ObservableCollection<Patient>();
            }

            return flag;
        }

        public object Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(patientList, Formatting.Indented));

            return null;
        }
    }
}