using PhumlaKamnandi2024.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class BookingController
    {
        #region Data Fields
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        public static int currentReferenceNumber;
        RoomController roomController;

        enum Seasonality { Low = 550, Mid = 750, High = 995 }
        private Seasonality season;
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;

            roomController = new RoomController();
        }
        #endregion

        #region Find Rooms
        public Collection<Room> AvailableRooms(DateTime d1, DateTime d2)
        {
            Collection<Room> rooms = new Collection<Room>();
            foreach (Booking booking in bookings)
            {
                bool isAvailable = (d1 <= booking.CheckInDate && d2 >= booking.CheckOutDate) || // Booking completely within the specific range
                                    (d1 >= booking.CheckInDate && d2 <= booking.CheckOutDate) || // Booking completely covers the specific range if return tru-can't book
                                    (d1 >= booking.CheckInDate && d1 < booking.CheckOutDate ||      // Partial overlap at the beggining
                                    (d2 > booking.CheckInDate && d2 <= booking.CheckOutDate)); // Partial overlap at the end
                if (isAvailable)
                {
                    string roomID = booking.RoomNum;
                    Room room = roomController.Find(roomID);
                    if (!rooms.Contains(room))
                    {
                        rooms.Add(room);
                    }
                }
            }

            Collection<Room> availablelist = roomController.AllRooms;
            foreach (Room room in rooms)
            {
                if (availablelist.Contains(room))
                {
                    availablelist.Remove(room);
                }

            }
            return availablelist;
        }


        #endregion

        #region Calc season Costs
        public void CalculateSeasonality(DateTime CheckIn, DateTime CheckOut)
        {
            // Define the start and end dates for each season.
            DateTime lowSeasonStart = new DateTime(CheckIn.Year, 12, 1);
            DateTime lowSeasonEnd = new DateTime(CheckIn.Year, 12, 7);
            DateTime midSeasonStart = new DateTime(CheckIn.Year, 12, 8);
            DateTime midSeasonEnd = new DateTime(CheckIn.Year, 12, 16);
            DateTime highSeasonStart = new DateTime(CheckIn.Year, 12, 17);
            DateTime highSeasonEnd = new DateTime(CheckIn.Year, 12, 31);

            // Check if the stay falls within the specified date ranges.
            if (CheckIn >= lowSeasonStart && CheckOut <= lowSeasonEnd)
            {
                season = Seasonality.Low;
            }
            else if (CheckIn >= midSeasonStart && CheckOut <= midSeasonEnd)
            {
                season = Seasonality.Mid;
            }
            else if (CheckIn >= highSeasonStart && CheckOut <= highSeasonEnd)
            {
                season = Seasonality.High;
            }
            else { season = Seasonality.Low; }
        }
        public decimal CalculateCost(DateTime CheckIn, DateTime CheckOut)
        {
            TimeSpan duration = CheckOut - CheckIn;
            int daysOfStay = duration.Days;
            decimal cost = 0;
            CalculateSeasonality(CheckIn, CheckOut);
            switch (season)
            {
                case Seasonality.Low:
                    cost = daysOfStay * (int)season;
                    break;
                case Seasonality.Mid:
                    cost = daysOfStay * (int)season;
                    break;
                case Seasonality.High:
                    cost = daysOfStay * (int)season;
                    break;
                default:
                    cost = daysOfStay * 100;
                    break;
            }

            return cost;
        }
        #endregion

        #region Data Communication
        public void DataMaintenance(Booking aBooking, PhumlaKamnandiDB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(aBooking, operation);
            //perform operations on the collection
            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    bookings.Add(aBooking);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    index = FindIndex(aBooking);
                    bookings[index] = aBooking;  // replace booking at this index with the updated booking
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    index = FindIndex(aBooking);  // find the index of the specific booking in collection
                    bookings.RemoveAt(index);  // remove that booking from the collection
                    break;

            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Booking booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Searching through a collection

        public Booking Find(string bookingID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == bookingID);

            while (!(found) && (index < bookings.Count - 1))
            {
                index = index + 1;
                found = (bookings[index].BookingID == bookingID);
            }
            return bookings[index];

        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (aBooking.BookingID == bookings[counter].BookingID);
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (aBooking.BookingID == bookings[counter].BookingID);
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

        #region Unique Booking ID and Add a booking
        public string GenerateUniqueBookingID()
        {
            // Unique ID generated based on current time + counter
            string uniqueID = "B" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + currentReferenceNumber.ToString("D3");
            currentReferenceNumber++; // Increment counter for uniqueness
            return uniqueID;
        }

        public Booking CreateBooking(string guestID, string roomNo, int numAdults, int numChildren, DateTime checkIn, DateTime checkOut, string specialRequest)
        {
            Booking newBooking = new Booking
            {
                BookingID = GenerateUniqueBookingID(),
                GuestID = guestID,
                RoomNum = roomNo,
                NumAdults = numAdults,
                NumChildren = numChildren,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                SpecialRequest = specialRequest
            };

            // Insert the booking into the database
            DataMaintenance(newBooking, database.PhumlaKamnandiDB.DBOperation.Add);
            FinalizeChanges(newBooking);

            return newBooking;
        }
        #endregion
    }
}
