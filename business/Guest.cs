using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Guest : Person
    {
        #region Data Field
        private string email_;
        #endregion

        #region Property Method
        public string Email {  get { return email_; } set { email_ = value; } }
        #endregion

        #region Contructor
        public Guest() :base() { email_ = string.Empty; }

        public Guest(string guestID, string fullName, string cellPhone, string homeAddress, string email) : base(guestID, fullName, cellPhone, homeAddress)
        {
            Email = email;
        }
        #endregion
    }
}
