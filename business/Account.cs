using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Account
    {
        #region Data Members
        private string accountID_;
        private string guestID_;
        private string creditCardNo_, cardExpDate_;
        private decimal balance_ = 0;
        #endregion

        #region property Methods
        public string AccountID { get { return accountID_; } set { accountID_ = value; } }
        public string GuestID { get {return guestID_; } set { guestID_ = value; } }
        public string CreditCardNo { get { return creditCardNo_; } set { creditCardNo_ = value; } }
        public string CardExpDate { get { return cardExpDate_; } set { cardExpDate_ = value; } }
        public decimal Balance { get { return balance_; } set { balance_ = value; } }
        #endregion

        #region Constructors
        public Account()
        {
            accountID_ = string.Empty;
            guestID_ = string.Empty;
            creditCardNo_ = string.Empty;
            cardExpDate_ = string.Empty;
            balance_ = 0;
        }

        public Account(string accountId, string guestID, string cardNo, string cardExpDate, decimal balance)
        {
            accountID_ =    accountId;
            guestID_ = guestID;
            cardExpDate_ = cardExpDate;
            balance_ = balance;
        }
        #endregion

        #region Utility Methods
        public void incrBalance(decimal amount)
        {
            balance_ += amount;
        }
        public void decrBalance(decimal amount) { balance_ -= amount; }
        #endregion
    }
}
