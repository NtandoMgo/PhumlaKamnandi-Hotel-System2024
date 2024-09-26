using PhumlaKamnandi2024.business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.database
{
    public class GuestDB : PhumlaKamnandiDB
    {
        #region Data Fileds
        private string table1 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private Collection<Guest> guests;
        #endregion

        #region Property Method: Collection
        public Collection<Guest> AllGuests { get { return guests; } }
        #endregion

        #region Constructor
        public GuestDB() : base()
        {
            //RetrieveAllGuestsFromDB();
        }
        #endregion

        #region Utility Methods
        public void RetrieveAllGuests()
        {
            dsMain.Tables["Guest"].Clear();
            RetrieveAllGuestsFromDB();
        }

        public void RetrieveAllGuestsFromDB()
        {
            //fill data set
            guests = new Collection<Guest>();

            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Guest guest;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guest = new Guest();

                    //Obtain each guest attribute from the specific field in the row in the table
                    guest.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                    guest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    guest.Cell = Convert.ToString(myRow["Cell"]).TrimEnd();
                    guest.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    guest.Address = Convert.ToString(myRow["Address"]).TrimEnd();

                    //add guest to guest collection
                    guests.Add(guest);

                }
            }
        }

        private void FillRow(DataRow aRow, Guest aGuest, PhumlaKamnandiDB.DBOperation operation)
        {

            if (operation == PhumlaKamnandiDB.DBOperation.Add)
            {
                aRow["ID"] = aGuest.ID;
                aRow["Name"] = aGuest.Name;
                aRow["Cell"] = aGuest.Cell;
                aRow["Email"] = aGuest.Email;
                aRow["Address"] = aGuest.Address;

            }
        }

        private int FindRow(Guest aGuest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aGuest.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Guest aGuest, PhumlaKamnandiDB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aGuest, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow); //Add to the dataset
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    // Find row to update
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    //Fill this row for the update operation by calling the FillRow method
                    FillRow(aRow, aGuest, operation);
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    //find row and delete it
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 13, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Cell", SqlDbType.NVarChar, 15, "Cell");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.Int, 15, "ID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Cell", SqlDbType.NVarChar, 15, "Cell");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.Int, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Remove(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Remove(param);

            param = new SqlParameter("@Cell", SqlDbType.NVarChar, 15, "Cell");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Remove(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Remove(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Remove(param);
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (ID, Name, Cell, Email, Address) VALUES (@ID, @Name, @Cell, @Email, @Address)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        private void Create_UPDATE_Command(Guest aGuest)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET ID = @ID, Name = @Name, Cell = @Cell, Email = @Email, Address = @Address" + "WHERE ID = @ID", cnMain);
            Build_UPDATE_Parameters(aGuest);
        }
        private string Create_DELETE_Command(Guest aGuest)
        {
            string errorString = null;
            //Command used to delete values from the Guest table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guest WHERE ID = @ID", cnMain);

            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            Create_UPDATE_Command(aGuest);
            Create_DELETE_Command(aGuest);

            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool UpdateGuestDataSource(Guest aGuest)
        {
            bool success = true;
            Create_UPDATE_Command(aGuest);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool InsertGuestDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion
    }
}
