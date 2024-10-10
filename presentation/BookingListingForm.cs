using PhumlaKamnandi2024.business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi2024.presentation
{
    public partial class BookingListingForm : Form
    {
        #region Data Fields
        private BookingController bookingController;
        private Collection<Booking> bookings;
        private AccountController accountController;
        private FormState currentState;
        private DateTime originalCheckInDate;
        private DateTime originalCheckOutDate;
        private bool datesChanged = false;
        string aGuestId, aBookingId, aRoomNum, requests, origReq;
        int adults, kids;
        private enum FormState
        {
            View,
            Edit,
            Delete
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool val)
        {
            edit_btn.Visible = !val;

            dateTimePicker1.Visible = val;
            dateTimePicker2.Visible = val;

            requests_txt.Visible = val;
            bookind_id_txt.Visible = val;
            guest_id_txt.Visible=val;
            roomNum_xtx.Visible = val;
            new_bal_txt.Visible = val;
            new_bal_txt.ReadOnly = true;

            //updateBtn.Visible = val;
            //updateBtn.Visible = datesChanged; // Show update button only if dates have not changed
        }
        private void ClearAll()
        {
            // Clear text boxes
            bookind_id_txt.Clear();
            guest_id_txt.Clear();
            roomNum_xtx.Clear();
            requests_txt.Clear();
            new_bal_txt.Clear();

            // Reset date time pickers to default values (e.g., today's date)
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            // Reset original dates and change tracking
            originalCheckInDate = DateTime.Today;
            originalCheckOutDate = DateTime.Today;
            datesChanged = false;

            // Refresh button visibility
            ShowAll(false);
        }

        #endregion

        #region Constructor
        public BookingListingForm()
        {
            InitializeComponent();
            bookingController = new BookingController();

            bookings = bookingController.GetAllBookings;

            bookingsDataGridView.DataSource = bookings;
            bookingsDataGridView.Columns["BookingID"].ReadOnly = true;
            bookingsDataGridView.Columns["GuestID"].ReadOnly = true;
            bookingsDataGridView.Columns["RoomNum"].ReadOnly = true;
        }
        #endregion

        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            currentState = FormState.View;
            ShowAll(false);
        }

        #region Buttons
        private void edit_btn_Click(object sender, EventArgs e)
        {
            currentState = FormState.Edit;
            ShowAll(true);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Check if the check-in date is before the check-out date
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Check-in date must be before check-out date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Booking updatedBooking = new Booking
            {
                BookingID = aBookingId,
                GuestID = aGuestId,
                RoomNum = aRoomNum,
                CheckInDate = dateTimePicker1.Value,
                CheckOutDate = dateTimePicker2.Value,
                SpecialRequest = requests_txt.Text,
                NumAdults = adults,
                NumChildren = kids
            };
            if (string.IsNullOrEmpty(bookind_id_txt.Text))
            {
                MessageBox.Show("Please select the booking..");
                return;
            }
            bookingController.DataMaintenance(updatedBooking, database.PhumlaKamnandiDB.DBOperation.Update);
            //bookingController.FinalizeChanges(updatedBooking);

            RefreshDataGrid();

            accountController = new AccountController();
            Account anAccount = accountController.Find(aGuestId);
            anAccount.decrBalance(bookingController.CalculateCost(originalCheckInDate, originalCheckOutDate));
            anAccount.incrBalance(bookingController.CalculateCost(dateTimePicker1.Value, dateTimePicker2.Value));

            accountController.DataMaintenance(anAccount, database.PhumlaKamnandiDB.DBOperation.Update);

            MessageBox.Show("Booking Updated.");

            currentState = FormState.View;
            ClearAll();
            ShowAll(false);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Delete button
            //bookingController.DataMaintenance()
            if (!(string.IsNullOrEmpty(bookind_id_txt.Text)))
            {
                //var selectedRow = bookingsDataGridView.SelectedRows[0];
                //string bookingIdToDelete = selectedRow.Cells["BookingID"].Value.ToString();
                string bookingIdToDelete = bookind_id_txt.Text;

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this booking?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Booking bookingToDelete = new Booking(aBookingId, aGuestId, aRoomNum, adults, kids, originalCheckInDate, originalCheckOutDate, requests);
                    //bookingController.DataMaintenance(bookingToDelete, database.PhumlaKamnandiDB.DBOperation.Delete);

                    bool deleted = bookingController.DeleteBooking(bookingToDelete);

                    // Refresh the data grid
                    RefreshDataGrid();

                    if (deleted)
                    {
                        MessageBox.Show("Booking deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Deleted unsuccessful.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void bookingsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && currentState == FormState.Edit)
            {
                // Get the selected row
                var selectedRow = bookingsDataGridView.Rows[e.RowIndex];

                // Populate text boxes
                aBookingId = selectedRow.Cells["BookingID"].Value.ToString();
                bookind_id_txt.Text = aBookingId;

                aGuestId = selectedRow.Cells["GuestID"].Value.ToString();
                guest_id_txt.Text = aGuestId;

                aRoomNum = selectedRow.Cells["RoomNum"].Value.ToString();
                roomNum_xtx.Text = aRoomNum;

                // Populate DateTimePickers
                originalCheckInDate = Convert.ToDateTime(selectedRow.Cells["CheckInDate"].Value);
                originalCheckOutDate = Convert.ToDateTime(selectedRow.Cells["CheckOutDate"].Value);
                dateTimePicker1.Value = originalCheckInDate;
                dateTimePicker2.Value = originalCheckOutDate;

                // Populate requests text box if applicable
                requests_txt.Text = selectedRow.Cells["SpecialRequest"].Value?.ToString() ?? string.Empty;
                origReq = requests_txt.Text;
                // Set text boxes to read-only
                bookind_id_txt.ReadOnly = true;
                guest_id_txt.ReadOnly = true;
                roomNum_xtx.ReadOnly = true;
                new_bal_txt.ReadOnly = true;

                // Calculate the initial balance
                decimal bal = bookingController.CalculateCost(dateTimePicker1.Value, dateTimePicker2.Value);
                new_bal_txt.Text = bal.ToString();

                adults = Convert.ToInt32(selectedRow.Cells["NumAdults"].Value);
                kids = Convert.ToInt32(selectedRow.Cells["NumChildren"].Value);

                // Reset dates changed flag
                datesChanged = false;
                ShowAll(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Methods
        private void RefreshDataGrid()
        {
            bookings = bookingController.GetAllBookings;
            bookingsDataGridView.DataSource = bookings;
        }
        private void CheckForDateChange()
        {
            bool datesHaveChanged = dateTimePicker1.Value != originalCheckInDate || dateTimePicker2.Value != originalCheckOutDate;

            // Enable update button only if the dates have changed or if the request has changed
            if (datesHaveChanged || requests_txt.Text != origReq)
            {
                datesChanged = true;
                new_bal_txt.Text = bookingController.CalculateCost(dateTimePicker1.Value, dateTimePicker2.Value).ToString();
            }
            else
            {
                datesChanged = false;
            }

            ShowAll(true); // Update button visibility based on datesChanged
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CheckForDateChange();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CheckForDateChange();
        }
        #endregion
    }
}
