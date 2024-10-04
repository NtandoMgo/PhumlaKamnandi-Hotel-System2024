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
    public class BookingDB : PhumlaKamnandiDB
    {
        #region Data Fields
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private Collection<Booking> allBookings;
        #endregion

        #region Property Method
        public Collection<Booking> AllBookings { get { return allBookings; } }

        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            RetrieveAllBookingsFromDB();
        }
        #endregion

        #region Utility Methods
        public string GenerateBookingID()
        {
            string prefix = "B";
            int maxID = GetMaxBookingID();

            maxID += 1;

            string newBookingID = $"{prefix}{maxID:D9}"; // Format as 'B000000001'

            if (newBookingID.Length > 10)
            {
                throw new Exception("Generated BookingID exceeds the maximum length of 10 characters.");
            }

            return newBookingID;
        }


        private int GetMaxBookingID()
        {
            int maxID = 0;

            // SQL query to get the maximum BookingID
            string query = "SELECT MAX(CAST(SUBSTRING(BookingID, 2, LEN(BookingID) - 1) AS INT)) FROM Booking";

            // execute the query
            using (SqlCommand command = new SqlCommand(query, cnMain))
            {
                try
                {
                    // Open the connection if it's not already open
                    if (cnMain.State != ConnectionState.Open)
                    {
                        cnMain.Open();
                    }

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        maxID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving max BookingID: {ex.Message}");
                }
                finally
                {
                    if (cnMain.State == ConnectionState.Open)
                    {
                        cnMain.Close();
                    }
                }
            }

            return maxID;
        }


        public void RetrieveAllBookings()
        {
            dsMain.Tables["Booking"].Clear();
            RetrieveAllBookingsFromDB();
        }

        public void RetrieveAllBookingsFromDB()
        {
            
            allBookings = new Collection<Booking>();

            //fill data set
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
            Booking booking;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    booking = new Booking();
                    booking.BookingID = Convert.ToString(myRow["BookingID"]);
                    booking.GuestID = Convert.ToString(myRow["GuestID"]);
                    booking.RoomNum = Convert.ToString(myRow["RoomNo"]);
                    booking.NumAdults = Convert.ToInt32(myRow["NumAdults"]);
    
                    object value = (myRow["NumChildren"]);
                    if (value != DBNull.Value)
                    {
                        booking.NumChildren = Convert.ToInt32(value);

                    }

                    booking.CheckInDate = Convert.ToDateTime(myRow["CheckInDate"]);
                    booking.CheckOutDate = Convert.ToDateTime(myRow["CheckOutDate"]);
                    booking.SpecialRequest = Convert.ToString(myRow["SpecialRequest"]);
                    
                    allBookings.Add(booking);

                }
            }
        }
        private void FillRow(DataRow aRow, Booking aBooking, PhumlaKamnandiDB.DBOperation operation)
        {

            if (operation == PhumlaKamnandiDB.DBOperation.Add)
            {
                aRow["BookingID"] = aBooking.BookingID;
                aRow["GuestID"] = aBooking.GuestID;
                aRow["RoomNo"] = aBooking.RoomNum;
                aRow["NumAdults"] = aBooking.NumAdults;
                aRow["NumChildren"] = aBooking.NumChildren;
                aRow["CheckInDate"] = aBooking.CheckInDate;
                aRow["CheckOutDate"] = aBooking.CheckOutDate;
                aRow["SpecialRequest"] = aBooking.SpecialRequest;
            }
        }

        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aBooking.BookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
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
        public void DataSetChange(Booking aBooking, PhumlaKamnandiDB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aBooking, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    FillRow(aRow, aBooking, operation);
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 10, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 5, "RoomNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumAdults", SqlDbType.Int, 10, "NumAdults");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumChildren", SqlDbType.Int, 10, "NumChildren");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 10, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 10, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);


            param = new SqlParameter("@SpecialRequest", SqlDbType.NVarChar, 255, "SpecialRequest");
            daMain.InsertCommand.Parameters.Add(param);
        }


        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 10, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 5, "RoomNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NumAdults", SqlDbType.Int, 10, "NumAdults");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NumChildren", SqlDbType.Int, 10, "NumChildren");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 10, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 10, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            param = new SqlParameter("@SpecialRequest", SqlDbType.NVarChar, 255, "SpecialRequest");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //Create Parameters to communicate with SQL DELETE
            SqlParameter param;

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 10, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 13, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 5, "RoomNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@NumAdults", SqlDbType.Int, 10, "NumAdults");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@NumChildren", SqlDbType.Int, 10, "NumChildren");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 10, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 10, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);


            param = new SqlParameter("@SpecialRequest", SqlDbType.NVarChar, 255, "SpecialRequest");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

        }

        private void Create_INSERT_Command(Booking aBooking)
        {
            //Command used to insert values into the Bookings table..

            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, GuestID, RoomNo, NumAdults, NumChildren, CheckInDate, CheckOutDate, SpecialRequest)" +
                " VALUES (@BookingID, @GuestID, @RoomNo, @NumAdults, @NumChildren, @CheckInDate, @CheckOutDate, @SpecialRequest)", cnMain);
            Build_INSERT_Parameters(aBooking);
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {
            //Command that must be used to insert values into bookings table
            //The GuestID and BookingReference cannot be changed

            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET BookingID =@BookingID, GuestID =@GuestID, RoomNo =@RoomNo,  NumAdults =@NumAdults, NumChildren =@NumChildren, CheckInDate =@CheckInDate, " +
                "CheckOutDate =@CheckOutDate, SpecialRequest =@SpecialRequest WHERE BookingID = @BookingID", cnMain);
            Build_UPDATE_Parameters(aBooking);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);

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

        //update data source
        public bool UpdateDataSource(Booking aBooking)
        {
            bool success = true;
            Create_INSERT_Command(aBooking);
            Create_UPDATE_Command(aBooking);
            Create_DELETE_Command(aBooking);

            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool UpdateBookingDataSource(Booking booking)
        {
            bool success = true;
            Create_UPDATE_Command(booking);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool InsertBookingDataSource(Booking booking)
        {
            bool success = true;
            Create_INSERT_Command(booking);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool DeleteBookingDataSource(Booking booking)
        {
            bool success = true;
            Create_DELETE_Command(booking);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion
    }
}
