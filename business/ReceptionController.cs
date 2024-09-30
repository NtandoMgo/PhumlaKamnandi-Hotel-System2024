using PhumlaKamnandi2024.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class ReceptionController
    {
        #region Data Fields
        private ReceptionDB receptionistDB;
        private Collection<Receptionist> receptionists;
        #endregion

        #region Property Method
        public Collection<Receptionist> AllReceptionists
        {
            get
            {
                return receptionists;
            }
        }
        #endregion

        #region Constructor
        public ReceptionController()
        {
            receptionistDB = new ReceptionDB();
              receptionists = receptionistDB.AllReceptionists;
        }
        #endregion
    }
}
