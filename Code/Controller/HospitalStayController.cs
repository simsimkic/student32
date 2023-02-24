/***********************************************************************
 * Module:  HospitalStayController.cs
 * Purpose: Definition of the Class Controller.HospitalStayController
 ***********************************************************************/

using Model.Director;
using System;

namespace Controller
{
   public class HospitalStayController
   {
      public HospitalStay CreateHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
         return false;
      }
      
      public HospitalStay EditHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
         return null;
      }
      
      public HospitalStayController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private HospitalStayController()
      {
         // TODO: implement
      }
   
      public Service.HospitalStayService hospitalStayService;
   
      private static HospitalStayController instance=null;

        public static HospitalStayController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HospitalStayController();
                }
                return instance;
            }
        }

    }
}