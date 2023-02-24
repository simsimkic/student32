/***********************************************************************
 * Module:  Stockroom.cs
 * Purpose: Definition of the Class Model.Director.Stockroom
 ***********************************************************************/

using System;

namespace Model.Director
{
   public class Stockroom
   {
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
      public System.Collections.ArrayList medicament;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicament()
      {
         if (medicament == null)
            medicament = new System.Collections.ArrayList();
         return medicament;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicament(System.Collections.ArrayList newMedicament)
      {
         RemoveAllMedicament();
         foreach (Medicament oMedicament in newMedicament)
            AddMedicament(oMedicament);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicament(Medicament newMedicament)
      {
         if (newMedicament == null)
            return;
         if (this.medicament == null)
            this.medicament = new System.Collections.ArrayList();
         if (!this.medicament.Contains(newMedicament))
            this.medicament.Add(newMedicament);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicament(Medicament oldMedicament)
      {
         if (oldMedicament == null)
            return;
         if (this.medicament != null)
            if (this.medicament.Contains(oldMedicament))
               this.medicament.Remove(oldMedicament);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicament()
      {
         if (medicament != null)
            medicament.Clear();
      }
   
   }
}