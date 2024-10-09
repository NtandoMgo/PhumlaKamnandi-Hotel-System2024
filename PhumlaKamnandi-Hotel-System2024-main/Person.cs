using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024
{
    public class Person
    {
        #region Data Fields
        private string ID_;
        private string name_;
        private string cell_;
        private string address_;
        #endregion

        #region Property Methods
        public string ID { get { return ID_; } set { ID_ = value; } }
        public string Name { get { return name_; } set { name_ = value; } }
        public string Cell { get { return cell_; } set { cell_ = value; } }
        public string Address { get { return address_; } set { address_ = value; } }
        #endregion

        #region Constructor
        public Person ()
        {
            ID_ = string.Empty;
            name_ = string.Empty;
            cell_ = string.Empty;
            address_ = string.Empty;
        }

        public Person(string id, string fullName, string cellPhone, string homeAddress)
        {
            ID = id;
            Name = fullName;
            Cell = cellPhone;
            Address = homeAddress;
        }


        #endregion
    }
}
