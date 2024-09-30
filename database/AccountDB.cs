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
    public class AccountDB : PhumlaKamnandiDB
    {
        #region Data Members
        private string table1 = "Account";
        private string sqlLocal1 = "SELECT * FROM Account";
        private Collection<Account> accounts;
        #endregion

        #region Constructor
        public AccountDB() : base()
        {
            AllAccountsFromDB();
        }
        #endregion

        #region Property Method: Collection
        public Collection<Account> AllAccounts { get { return accounts; } }
        #endregion

        #region Utility Methods
        public void GetAllAccounts()
        {
            dsMain.Tables[table1].Clear();
            AllAccountsFromDB();
        }

        public void AllAccountsFromDB()
        {
            accounts = new Collection<Account>();

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
            Account account;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    account = new Account();
                    account.AccountID = Convert.ToString(myRow["AccountID"]);
                    account.GuestID = Convert.ToString(myRow["GuestID"]);
                    account.CreditCardNo = Convert.ToString(myRow["CCNo"]);
                    account.CardExpDate = Convert.ToString(myRow["CCDate"]);
                    account.Balance = Convert.ToDecimal(myRow["Balance"]);
                    accounts.Add(account);

                }
            }
        }

        private void FillRow(DataRow aRow, Account aAccount, PhumlaKamnandiDB.DBOperation operation)
        {

            if (operation == PhumlaKamnandiDB.DBOperation.Add)
            {
                aRow["AccountID"] = aAccount.AccountID;
                aRow["GuestID"] = aAccount.GuestID;
                aRow["CCNo"] = aAccount.CreditCardNo;
                aRow["CCDate"] = aAccount.CardExpDate;
                aRow["Balance"] = aAccount.Balance;
            }
        }

        private int FindRow(Account aAccount, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aAccount.AccountID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["AccountID"]))
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
        public void DataSetChange(Account aAccount, PhumlaKamnandiDB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aAccount, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aAccount, dataTable)];
                    FillRow(aRow, aAccount, operation);
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aAccount, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Account aAccount)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 5, "AccountID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CrediCardNo", SqlDbType.NVarChar, 16, "CrediCardNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CardExpDate", SqlDbType.NVarChar, 7, "CardExpDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Balance", SqlDbType.Decimal, 20, "Balance");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Account aAccount)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 5, "AccountID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CrediCardNo", SqlDbType.NVarChar, 16, "CrediCardNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CardExpDate", SqlDbType.NVarChar, 7, "CardExpDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Balance", SqlDbType.Decimal, 20, "Balance");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            SqlParameter param;

            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 5, "AccountID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@CrediCardNo", SqlDbType.NVarChar, 16, "CrediCardNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@CardExpDate", SqlDbType.NVarChar, 7, "CardExpDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@Balance", SqlDbType.Decimal, 20, "Balance");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

        }

        private void Create_INSERT_Command(Account aAccount)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into Account (AccountID, GuestID, CCNo, CCDate, Balance) VALUES (@AccountID, @GuestID, @CCNo, @CCDate, @Balance)", cnMain);
            Build_INSERT_Parameters(aAccount);
        }

        private void Create_UPDATE_Command(Account aAccount)
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Account SET AccountID = @AccountID, GuestID = @GuestID, CCNo = @CCNo, CCDate = @CCDate, Balance = @Balance " + "WHERE AccountID = @AccountID", cnMain);
            Build_UPDATE_Parameters(aAccount);
        }

        private string Create_DELETE_Command(Account aAccount)
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Account WHERE AccountID = @AccountID", cnMain);

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

        public bool UpdateDataSource(Account aAccount)
        {
            bool success = true;
            Create_INSERT_Command(aAccount);
            Create_UPDATE_Command(aAccount);
            Create_DELETE_Command(aAccount);

            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool UpdateAccountDataSource(Account aAccount)
        {
            bool success = true;
            Create_UPDATE_Command(aAccount);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool InsertAccountDataSource(Account aAccount)
        {
            bool success = true;
            Create_INSERT_Command(aAccount);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool DeleteAccountDataSource(Account account)
        {
            bool success = true;
            Create_DELETE_Command(account);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion
    }
}
