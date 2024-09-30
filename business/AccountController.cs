using PhumlaKamnandi2024.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class AccountController
    {
        #region Data Members
        private AccountDB accountDB;
        private Collection<Account> accounts;
        #endregion

        #region Property method
        public Collection<Account> AllAccounts
        {
            get
            {
                return accounts;
            }
        }
        #endregion

        #region Constructor
        public AccountController()
        {
            accountDB = new AccountDB();
            accounts = accountDB.AllAccounts;
        }

        #endregion

        #region Methods
        public int generateAccountID()
        {
            AccountDB accountDB = new AccountDB();
            accounts = accountDB.AllAccounts;
            return accounts.Count() + 1;
        }
        #endregion

        #region Database Communication.

           public void DataMaintenance(Account aAccount, PhumlaKamnandiDB.DBOperation operation)
        {
            int index = 0;
            accountDB.DataSetChange(aAccount, operation);
            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    accounts.Add(aAccount);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    index = FindIndex(aAccount);
                    accounts[index] = aAccount;
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    index = FindIndex(aAccount); 
                    accounts.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(Account account)
        {
            return accountDB.UpdateDataSource(account);
        }
        #endregion

        #region Searching through a collection

        public Account Find(string aID)
        {
            AccountDB accountDB = new AccountDB();
            accounts = accountDB.AllAccounts;
            Account foundAccount = null;
            if (accounts.Any(x => x.AccountID == aID))
            {
                foundAccount = accounts.First(x => x.AccountID == aID);
            }
            return foundAccount;
        }

        public int FindIndex(Account aAccount)
        {
            int counter = 0;
            bool found = false;
            found = (aAccount.AccountID == accounts[counter].AccountID);
            while (!(found) & counter < accounts.Count - 1)
            {
                counter += 1;
                found = (aAccount.AccountID == accounts[counter].AccountID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
