/***********************************************************************
 * Module:  SpecialistDoctor.cs
 * Purpose: Definition of the Class Model.Doctor.SpecialistDoctor
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class SpecialistDoctor : Model.User.Doctor
   {
      public Specialization specialization;
      public System.Collections.ArrayList referToDocSpec;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetReferToDocSpec()
      {
         if (referToDocSpec == null)
            referToDocSpec = new System.Collections.ArrayList();
         return referToDocSpec;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetReferToDocSpec(System.Collections.ArrayList newReferToDocSpec)
      {
         RemoveAllReferToDocSpec();
         foreach (ReferToDocSpec oReferToDocSpec in newReferToDocSpec)
            AddReferToDocSpec(oReferToDocSpec);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddReferToDocSpec(ReferToDocSpec newReferToDocSpec)
      {
         if (newReferToDocSpec == null)
            return;
         if (this.referToDocSpec == null)
            this.referToDocSpec = new System.Collections.ArrayList();
         if (!this.referToDocSpec.Contains(newReferToDocSpec))
         {
            this.referToDocSpec.Add(newReferToDocSpec);
            newReferToDocSpec.SetSpecialistDoctor(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveReferToDocSpec(ReferToDocSpec oldReferToDocSpec)
      {
         if (oldReferToDocSpec == null)
            return;
         if (this.referToDocSpec != null)
            if (this.referToDocSpec.Contains(oldReferToDocSpec))
            {
               this.referToDocSpec.Remove(oldReferToDocSpec);
               oldReferToDocSpec.SetSpecialistDoctor((SpecialistDoctor)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllReferToDocSpec()
      {
         if (referToDocSpec != null)
         {
            System.Collections.ArrayList tmpReferToDocSpec = new System.Collections.ArrayList();
            foreach (ReferToDocSpec oldReferToDocSpec in referToDocSpec)
               tmpReferToDocSpec.Add(oldReferToDocSpec);
            referToDocSpec.Clear();
            foreach (ReferToDocSpec oldReferToDocSpec in tmpReferToDocSpec)
               oldReferToDocSpec.SetSpecialistDoctor((SpecialistDoctor)null);
            tmpReferToDocSpec.Clear();
         }
      }

        public SpecialistDoctor(Specialization specialization)
        {
            this.specialization = specialization;
        }
    }
}