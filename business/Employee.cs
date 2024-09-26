using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Employee : Person
    {
        #region Data Fields
        private string password_;
        private Role roleVal;
        #endregion
        #region Role Class
        public enum Role
        {
            Receptionist = 0,
            Admin = 1,
            Manager = 2,
        }
        #endregion
        #region Property Method
        public string Password { get { return password_; } set { password_ = value; } }
        #endregion

        #region Contructor
        public Employee() : base() { password_ = string.Empty; }

        public Employee(string password, string empID, string fullName, string cellPhone, string homeAddress) : base(empID, fullName, cellPhone, homeAddress)
        {
            password_ = password;
        }
        #endregion
    }
}
