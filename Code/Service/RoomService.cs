/***********************************************************************
 * Module:  RoomService.cs
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Director;
using System;

namespace Service
{
   public class RoomService
   {
      public Room AddRoom(Room room)
      {
         // TODO: implement
         return null;
      }
      
      public Room ChangeTypeOfRoom(Model.Director.Room room)
      {
         // TODO: implement
         return null;
      }
      
      public Room DeleteRoom(Room room)
      {
         // TODO: implement
         return null;
      }
      
      public Equipment AddEquipmentToRoom(Model.Director.Room room, Model.Director.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean RemoveEquipmentFromRoom(Model.Director.Room room, Model.Director.Equipment equipment)
      {
         // TODO: implement
         return false;
      }
      
      public RoomType AddNewRoomType(Model.Director.RoomType roomType)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean IsRoomFree(Model.Director.Room room)
      {
         // TODO: implement
         return false;
      }
      
      public RoomService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private RoomService()
      {
         // TODO: implement
      }
   
      public Repository.RoomRepository roomRepository;
   
      private static RoomService instance = null;

        public static RoomService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomService();
                }
                return instance;
            }
        }

    }
}