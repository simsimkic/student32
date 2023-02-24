/***********************************************************************
 * Module:  MedicalService.cs
 * Purpose: Definition of the Class Model.Doctor.MedicalService
 ***********************************************************************/

using Model.Director;
using System;

namespace Model.Doctor
{
   public class MedicalService
   {
      public Model.Director.Room room;
   
      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }

        public MedicalService()
        {
        }

        public MedicalService(Room room, DateTime startTime, DateTime endTime)
        {
            this.room = room;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}