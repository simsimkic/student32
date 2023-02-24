/***********************************************************************
 * Module:  RoomController.cs
 * Purpose: Definition of the Class Controller.RoomController
 ***********************************************************************/

using Model.Director;
using System;

namespace Controller
{
   public class RoomController
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
      
      public Model.Director.Renovation AddRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return false;
      }
      
      public Model.Director.Renovation EditRenovation(Model.Director.Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public RoomController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private RoomController()
      {
         // TODO: implement
      }
   
      public Service.RoomService roomService;
      public Service.RenovationService renovationService;

        private static RoomController instance = null;

        public static RoomController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomController();
                }
                return instance;
            }
        }

    }
}