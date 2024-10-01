using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Booking
    {
        #region Data Members
        private string bookingID_;
        private int numAdults_, numChildren_;
        private string guestID_, specialRequest_;
        private string roomNo_;
        private DateTime checkInDate_, checkOutDate_;
        private decimal balance_ = 0;
        #endregion

        #region Property Methods
        public string BookingID {  get { return bookingID_; } set { bookingID_ = value; } }
        public int NumAdults { get { return numAdults_; } set { numAdults_ = value; } }
        public int NumChildren { get { return numChildren_; } set { numChildren_ = value; } }
        public string GuestID { get {return guestID_; } set { guestID_ = value; } }
        public string RoomNum { get { return roomNo_; } set { roomNo_ = value; } }
        public string SpecialRequest { get { return specialRequest_; } set { specialRequest_ = value; } }
        public DateTime CheckInDate { get { return checkInDate_; } set { checkInDate_ = value; } }
        public DateTime CheckOutDate { get {return checkOutDate_; } set {checkOutDate_ = value; } }

        public decimal Balance { get { return balance_; } set { balance_ = value; } }
        #endregion

        #region Constructors
        public Booking()
        {
            bookingID_ = string.Empty;
            numAdults_ = 0; numChildren_ = 0;
            specialRequest_ = string.Empty;
            guestID_ = string.Empty;
            roomNo_ = string.Empty;
            checkOutDate_ = DateTime.MinValue;
            checkInDate_ = DateTime.MinValue;
        }
        public Booking (string bookingID, string guestID, string roomNo, int numOfAdults, int numOfChildren, DateTime checkIn, DateTime checkOut, string request)
        {
            BookingID = bookingID;
            GuestID = guestID;
            RoomNum = roomNo;
            SpecialRequest = request;
            NumAdults = numOfAdults;
            NumChildren = numOfChildren;
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
        }
        #endregion
    }
}
