using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Receptionist : Person
    {
        #region Data Fields
        private string password_;
        #endregion

        #region Property Method
        public string Password { get { return password_; } set { password_ = value; } }
        #endregion

        #region Contructor
        public Receptionist() : base() { password_ = string.Empty; }

        public Receptionist(string password, string empID, string fullName, string cellPhone, string homeAddress) : base( empID, fullName,  cellPhone, homeAddress) 
        { 
            password_ = password; 
        }
        #endregion
    }
}
