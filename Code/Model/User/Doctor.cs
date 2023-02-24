/***********************************************************************
 * Module:  Doctor.cs
 * Purpose: Definition of the Class Model.User.Doctor
 ***********************************************************************/

using Model.Director;
using System;
using static Model.User.Gender;
using static Model.User.Role;

namespace Model.User
{
    public class Doctor : User
    {
        public WorkTime workTime;
        public AnnualLeave[] annualLeave;

        public string fullName { get; set; }

        public Doctor()
        {

        }

        public Doctor(string firstName, string lastName, DateTime dateOfBirth, string email, string jmbg, string address, string pass, GenderEnum gender, RoleEnum role) : base(firstName, lastName, dateOfBirth, email, jmbg, address, pass, gender, role)
        {
            this.fullName = "dr. " + firstName + " " + lastName;
        }

    }
}