/***********************************************************************
 * Module:  IDoctorRepository.cs
 * Purpose: Definition of the Interface Repository.IDoctorRepository
 ***********************************************************************/

using Model.User;
using System;

namespace Repository
{
   public interface IDoctorRepository : IRepository
   {
      Doctor GetDoctorByUsername(String doctorUsername);
      Doctor GetDoctorsBySpecialization(String specialization);
   }
}