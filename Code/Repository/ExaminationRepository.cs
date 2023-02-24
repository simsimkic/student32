/***********************************************************************
 * Module:  ExaminationRepository.cs
 * Purpose: Definition of the Class Repository.ExaminationRepository
 ***********************************************************************/

using HospPatient.Code.Model.PatientSecretary;
using Model.Doctor;
using Model.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Repository
{
   public class ExaminationRepository : IExaminationRepository
   {
      private String Path = @"\\Mac\Home\Desktop\Data\examinationRepo.json"; //zakazani pregledi
      private String Path2 = @"\\Mac\Home\Desktop\Data\examSlotRepo.json"; //slotovi slobodni

        //konkretni pravi pregledi zakazani, na pocetku je prazno
        public static ObservableCollection<Examination> examinationList = new ObservableCollection<Examination>();

        //slobodi termini koje cemo da uklanjamo kada rezervisemo isti
        public static Dictionary<string, Dictionary<string, List<ExaminationSlot> > > doctorExaminationSlots = new Dictionary<string, Dictionary<string, List<ExaminationSlot> > >();
                                                   //datum
        //IZMENIO DA SU STATICKA POLJA!        

        public void initSlots()
        {
            List<ExaminationSlot> timeSlots = new List<ExaminationSlot>();
            
            
            
            timeSlots.Add(new ExaminationSlot("08:00"));
            timeSlots.Add(new ExaminationSlot("08:30"));
            timeSlots.Add(new ExaminationSlot("09:00"));
            timeSlots.Add(new ExaminationSlot("09:30"));
            timeSlots.Add(new ExaminationSlot("10:00"));
            timeSlots.Add(new ExaminationSlot("10:30"));


            foreach (Doctor doc in DoctorRepository.doctorList ){
                string doctorUsername = doc.Username;

                           //datum
                Dictionary<string, List<ExaminationSlot>> slots = new Dictionary<string, List<ExaminationSlot>>();


                DateTime dt = DateTime.Now;
                
                for(int i = 0; i < 15; i++)
                {
                    String dateString = dt.ToString("MM/dd/yyyy");
                    //Console.WriteLine("DATUM U STRING: " + dateString);

                    slots.Add(dateString, timeSlots);

                    dt = dt.AddDays(1);
                }
                if (!doctorExaminationSlots.ContainsKey(doctorUsername)) 
                     doctorExaminationSlots.Add(doctorUsername, slots);
            }
            Save();

        }





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
            Examination exam = (Examination)obj;

            
            if (examinationList.Contains(exam))
            {
                MessageBox.Show("Termin je vec zauzet!");
                return null;
            }
            examinationList.Add(exam);
            Save();
            return exam;
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

        public Examination GetExaminationById(int examinationID)
        {
            throw new NotImplementedException();
        }

        public List<Examination> GetExaminationsByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Examination> GetExaminationsByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            bool flag = true;

            if (File.Exists(Path) && new FileInfo(Path).Length != 0)
            {
                examinationList = JsonConvert.DeserializeObject<ObservableCollection<Examination>>(File.ReadAllText(Path));
            }
            else
            {
                flag = false;
                examinationList = new ObservableCollection<Examination>();
            }

            //if((File.Exists(Path2) && new FileInfo(Path2).Length != 0)){
            //    doctorExaminationSlots = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<ExaminationSlot> > > >(File.ReadAllText(Path2));
            //}

            //else
            //{
            //    flag = false; 
            //     doctorExaminationSlots = new Dictionary<string, Dictionary<string, List<ExaminationSlot> > >();
            //}

            return flag;
        }
    

        public object Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(examinationList, Formatting.Indented));

            
            File.WriteAllText(Path2, JsonConvert.SerializeObject(doctorExaminationSlots, Formatting.Indented));

            return null;
        }
    }
}