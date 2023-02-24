/***********************************************************************
 * Module:  Room.cs
 * Purpose: Definition of the Class Model.Director.Room
 ***********************************************************************/

using System;
using System.Collections;

namespace Model.Director
{
   public class Room
   {
      public RoomType roomType;
      public System.Collections.ArrayList equipment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetEquipment()
      {
         if (equipment == null)
            equipment = new System.Collections.ArrayList();
         return equipment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetEquipment(System.Collections.ArrayList newEquipment)
      {
         RemoveAllEquipment();
         foreach (Equipment oEquipment in newEquipment)
            AddEquipment(oEquipment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddEquipment(Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.equipment == null)
            this.equipment = new System.Collections.ArrayList();
         if (!this.equipment.Contains(newEquipment))
            this.equipment.Add(newEquipment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveEquipment(Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.equipment != null)
            if (this.equipment.Contains(oldEquipment))
               this.equipment.Remove(oldEquipment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllEquipment()
      {
         if (equipment != null)
            equipment.Clear();
      }
      public System.Collections.ArrayList patient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatient()
      {
         if (patient == null)
            patient = new System.Collections.ArrayList();
         return patient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatient(System.Collections.ArrayList newPatient)
      {
         RemoveAllPatient();
         foreach (Model.User.Patient oPatient in newPatient)
            AddPatient(oPatient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatient(Model.User.Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.ArrayList();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatient(Model.User.Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }

      public int RoomId { get; set; }
      public int RoomCapacity { get; set; }
      public Boolean IsFull { get; set; }
      public int FloorNumber { get; set; }

        public Room(RoomType roomType, ArrayList equipment, ArrayList patient, int roomId, int roomCapacity, bool isFull, int floorNumber)
        {
            this.roomType = roomType;
            this.equipment = equipment;
            this.patient = patient;
            RoomId = roomId;
            RoomCapacity = roomCapacity;
            IsFull = isFull;
            FloorNumber = floorNumber;
        }
    }
}