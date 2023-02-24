/***********************************************************************
 * Module:  Renovation.cs
 * Purpose: Definition of the Class Model.Director.Renovation
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class Renovation
   {
      public Room room { get; set; }

      public DateTime DateStart { get; set; }
      public DateTime DateEnd { get; set; }
      public int RenovationId { get; set; }

        public Renovation(Room room, DateTime dateStart, DateTime dateEnd, int renovationId)
        {
            this.room = room;
            DateStart = dateStart;
            DateEnd = dateEnd;
            RenovationId = renovationId;
        }

    }
}