using PhumlaKamnandi2024.business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.database
{
    public class ReceptionDB : PhumlaKamnandiDB
    {
        #region Data Fields
        private string table1 = "Receptionist";
        private string sqlLocal1 = "SELECT * FROM Receptionist";
        private Collection<Receptionist> receptionists;
        #endregion

        #region Property Method
        public Collection<Receptionist> AllReceptionists { get { return receptionists; } }
        #endregion

        #region Constructor
        public ReceptionDB() : base()
        {
            GetAllReceptionistsFromDB();
        }
        #endregion

        #region Utility Methods
        public void GetAllReceptionists()
        {
            dsMain.Tables["Receptionist"].Clear();
            GetAllReceptionistsFromDB();
        }

        public void GetAllReceptionistsFromDB()
        {
            receptionists = new Collection<Receptionist>();

            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Receptionist receptionist;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    receptionist = new Receptionist();

                    //Obtain each guest attribute from the specific field in the row in the table
                    receptionist.ID = Convert.ToString(myRow["EmplID"]);
                    receptionist.Password = Convert.ToString(myRow["Password"]);
                    receptionists.Add(receptionist);

                }
            }
        }
     
        private int FindRow(Receptionist aReceptionist, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aReceptionist.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["EmplID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #endregion
    }
}
