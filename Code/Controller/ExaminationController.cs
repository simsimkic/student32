/***********************************************************************
 * Module:  ExaminationController.cs
 * Purpose: Definition of the Class Controller.ExaminationController
 ***********************************************************************/

using Model.Doctor;
using Service;
using System;
using System.Collections.ObjectModel;
using System.Dynamic;

namespace Controller
{
   public class ExaminationController
   {
      public Model.Doctor.Examination ScheduleExamination(Model.Doctor.Examination examination)
      {
         // TODO: implement
         return null;
      }

      public bool OpenFile()
        {
            ExaminationService es = ExaminationService.getInstance;

            return es.OpenFile();
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
      
      public Model.Doctor.Report CreateReport()
      {
         // TODO: implement
         return null;
      }

      public void Create(Examination e) {
            ExaminationService.getInstance.Create(e);
        }
      
      public ObservableCollection<Examination> getAllExaminations()
        {
            return ExaminationService.getInstance.getAllExaminations();
        }


      public ExaminationController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private ExaminationController()
      {
         // TODO: implement
      }
   
      public Service.ExaminationService examinationService;

        private static ExaminationController instance = null;

        public static ExaminationController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExaminationController();
                }
                return instance;
            }
        }

    }
}