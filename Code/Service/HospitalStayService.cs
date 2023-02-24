/***********************************************************************
 * Module:  HospitalStayService.cs
 * Purpose: Definition of the Class Service.HospitalStayService
 ***********************************************************************/

using Model.Director;
using System;

namespace Service
{
   public class HospitalStayService
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
      
      public HospitalStayService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private HospitalStayService()
      {
         // TODO: implement
      }
   
      public Repository.HospitalStayRepository hospitalStayRepository;
   
      private static HospitalStayService instance = null;

        public static HospitalStayService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HospitalStayService();
                }
                return instance;
            }
        }

    }
}