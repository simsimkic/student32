/***********************************************************************
 * Module:  RoomType.cs
 * Purpose: Definition of the Class Model.Director.RoomType
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class RoomType
   {
      public Room[] room { get; set; }

      public String Name { get; set; }

        public RoomType(string name)
        {
            Name = name;
        }
    }
}