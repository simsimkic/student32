/***********************************************************************
 * Module:  ReferToDocSpecService.cs
 * Purpose: Definition of the Class Service.ReferToDocSpecService
 ***********************************************************************/

using System;

namespace Service
{
   public class ReferToDocSpecService
   {
      public Model.Doctor.ReferToDocSpec CreateReferToDocSpec(ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.ReferToDocSpec EditReferToDocSpec(ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteReferToDocSpec(ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return false;
      }
      
      public ReferToDocSpecService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private ReferToDocSpecService()
      {
         // TODO: implement
      }
   
      public Repository.ReferToDocSpecRepository referToDocSpecRepository;
   
      private static ReferToDocSpecService instance = null;

        public static ReferToDocSpecService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReferToDocSpecService();
                }
                return instance;
            }
        }

    }
}