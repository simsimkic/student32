/***********************************************************************
 * Module:  ExaminationService.cs
 * Purpose: Definition of the Class Service.ExaminationService
 ***********************************************************************/

using Model.Doctor;
using Repository;
using System;
using System.Collections.ObjectModel;

namespace Service
{
   public class ExaminationService
   {
        private ExaminationRepository er = new ExaminationRepository();
        public Model.Doctor.Examination ScheduleExamination(Model.Doctor.Examination examination)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Examination EditExamination(Model.Doctor.Examination examination)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteExamination(Model.Doctor.Examination examination)
      {
         // TODO: implement
         return false;
      }

        public bool OpenFile()
        {
            
            return er.OpenFile(null);
        }

        public Model.Doctor.Report CreateReport()
      {
         // TODO: implement
         return null;
      }
      
      public ExaminationService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private ExaminationService()
      {
         // TODO: implement
      }

        public void Create(Examination e)
        {
           
            er.Create(e);
        }

        public Repository.EquipmentRepository equipmentRepository;

        public ObservableCollection<Examination> getAllExaminations()
        {
            return ExaminationRepository.examinationList;
        }

        private static ExaminationService instance = null;

        public static ExaminationService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExaminationService();
                }
                return instance;
            }
        }

    }
}