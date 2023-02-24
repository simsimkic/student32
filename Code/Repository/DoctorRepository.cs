/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository
 ***********************************************************************/

using Model.User;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Repository
{
   public class DoctorRepository : IDoctorRepository
   {


        public static ObservableCollection<Doctor> doctorList = new ObservableCollection<Doctor>();

        private String Path = @"\\Mac\Home\Desktop\Data\doctorRepo.txt";

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public object Create(object obj)
        {
            // throw new NotImplementedException();

            Doctor doc = (Doctor)obj;
            

            doctorList.Add(doc);
            Save();
            return doc;


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

        public Doctor GetDoctorByUsername(string doctorUsername)
        {
            foreach (Doctor doc in doctorList)
            {
                if (doc.Username.Equals(doctorUsername))
                {
                    return doc;
                }
            }
            return null;

        }

        public Doctor GetDoctorsBySpecialization(string specialization)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            bool flag = true;

            if (File.Exists(Path) && new FileInfo(Path).Length != 0)
            {
                doctorList = JsonConvert.DeserializeObject<ObservableCollection<Doctor>>(File.ReadAllText(Path));
            }
            else
            {
                flag = false;
                doctorList = new ObservableCollection<Doctor>();
            }

            return flag;
        }

        public object Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(doctorList, Formatting.Indented));

            return null;
        }
    }
}