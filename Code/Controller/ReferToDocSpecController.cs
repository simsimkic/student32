/***********************************************************************
 * Module:  ReferToDocSpecController.cs
 * Purpose: Definition of the Class Controller.ReferToDocSpecController
 ***********************************************************************/

using System;

namespace Controller
{
   public class ReferToDocSpecController
   {
      public Model.Doctor.ReferToDocSpec CreateReferToDocSpec(Service.ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.ReferToDocSpec EditReferToDocSpec(Service.ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteReferToDocSpec(Service.ReferToDocSpecService referToDocSpec)
      {
         // TODO: implement
         return false;
      }
      
      public Service.ReferToDocSpecService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private ReferToDocSpecController()
      {
         // TODO: implement
      }
   
      public Service.ReferToDocSpecService referToDocSpecService;

        private static ReferToDocSpecController instance = null;

        public static ReferToDocSpecController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReferToDocSpecController();
                }
                return instance;
            }
        }

    }
}