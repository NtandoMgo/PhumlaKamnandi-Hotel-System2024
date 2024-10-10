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
    public partial class BookingForm : Form
    {
        #region Data Fields
        private GuestController guestController;
        private Guest aGuest;
        private BookingController bookingController;
        private AccountController accountController;
        private int selectedAdult;
        private int selectedKids;
        #endregion

        #region Utility Methods
        public void PopulateGuestObject()
        {
            aGuest = new Guest();

            aGuest.ID = id_txt.Text;
            aGuest.Name = name_txt.Text;
            aGuest.Cell = cell_txt.Text;
            aGuest.Email = email_txt.Text;
            aGuest.Address = addr_txt.Text;
        }

        public void ShowAll(bool showAll)
        {
            // Determine the visibility based on the radio button states
            bool isNewGuestChecked = newGuest_btn.Checked;
            bool isExistingChecked = existing_btn.Checked;

            // Set the new value based on the parameter
            bool newValue = !showAll;

            // Hide or show controls based on radio button selections
            if (isNewGuestChecked)
            {
                id_lbl.Visible = showAll;
                id_txt.Visible = showAll;
                name_lbl.Visible = showAll;
                name_txt.Visible = showAll;
                cell_lbl.Visible = showAll;
                cell_txt.Visible = showAll;
                email_lbl.Visible = showAll;
                email_txt.Visible = showAll;
                address_lbl.Visible = showAll;
                addr_txt.Visible = showAll;

                card_no_lbl.Visible = showAll;
                card_tct.Visible = showAll;
                exp_lbl.Visible = showAll;
                exp_txt.Visible = showAll;

                register_btn.Visible = showAll;

                signin_Id_lbl.Visible = false;
                signIn__idi_txt.Visible = false;

                old_guest_signin_btn.Visible = false;
            }
            else if (isExistingChecked)
            {
                signin_Id_lbl.Visible = showAll;
                signIn__idi_txt.Visible = showAll;

                old_guest_signin_btn.Visible = showAll;

                // Hide new guest labels
                id_lbl.Visible = false;
                id_txt.Visible = false;
                name_lbl.Visible = false;
                name_txt.Visible = false;
                cell_lbl.Visible = false;
                cell_txt.Visible = false;
                email_lbl.Visible = false;
                email_txt.Visible = false;
                address_lbl.Visible = false;
                addr_txt.Visible = false;

                card_no_lbl.Visible = false;
                card_tct.Visible = false;
                exp_lbl.Visible = false;
                exp_txt.Visible = false;

                register_btn.Visible = false;
            }
            else // If neither radio button is checked
            {
                id_lbl.Visible = false;
                id_txt.Visible = false;
                name_lbl.Visible = false;
                name_txt.Visible = false;
                cell_lbl.Visible = false;
                cell_txt.Visible = false;
                email_lbl.Visible = false;
                email_txt.Visible = false;
                address_lbl.Visible = false;
                addr_txt.Visible = false;

                card_no_lbl.Visible = false;
                card_tct.Visible = false;
                exp_lbl.Visible = false;
                exp_txt.Visible = false;

                register_btn.Visible = false;

                signin_Id_lbl.Visible = false;
                signIn__idi_txt.Visible = false;

                old_guest_signin_btn.Visible = false;
            }
        }

        private void HideAll(bool value)
        {
            checkIn_lbl.Visible = value;
            checkOut_lbl.Visible = value;
            dateTimePicker1.Visible = value;
            dateTimePicker2.Visible = value;

            serch_button.Visible = value;

            listView1.Visible = value;

            label1.Visible = value;
            roomDisplay.Visible = value;

            adults_lbl.Visible = value;
            kids_lbl.Visible = value;
            adults_txt_num.Visible = value;
            kids_txt_num.Visible = value;

            requests_lbl.Visible = value;
            request_txt.Visible = value;

            proceed_btn.Visible = value;

            newGuest_btn.Visible = value;
            existing_btn.Visible = value;

            id_lbl.Visible = value;
            signIn__idi_txt.Visible= value;

            old_guest_signin_btn.Visible= value;
        }

        private void ClearAllFields()
        {
            // Clear New Guest Fields
            id_txt.Clear();
            name_txt.Clear();
            cell_txt.Clear();
            email_txt.Clear();
            addr_txt.Clear();
            card_tct.Clear();
            exp_txt.Clear();

            // Clear Existing Guest Fields
            signIn__idi_txt.Clear();

            

            // Clear room list view selection
            listView1.Items.Clear();

            // Reset radio buttons
            newGuest_btn.Checked = false;
            existing_btn.Checked = false;

            // Disable controls
            newGuest_btn.Enabled = false;
            existing_btn.Enabled = false;

            // Hide all controls related to guest info
            ShowAll(false);
        }

        #endregion
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            bookingController = new BookingController();
            guestController = new GuestController();
            accountController = new AccountController();

            Exit_done_button.Visible = false;

            listView1.View = View.List;
            listView2.View = View.List;
            listView2.Visible = false;

            newGuest_btn.Enabled = false;
            existing_btn.Enabled = false;
            ShowAll(false);

            roomDisplay.ReadOnly = true;

            DateTime maxDate = DateTime.Now.AddMonths(6);
            dateTimePicker1.MaxDate = maxDate;
            dateTimePicker2.MaxDate = maxDate;
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newGuest_btn_CheckedChanged(object sender, EventArgs e)
        {
            ShowAll(newGuest_btn.Checked);
        }

        private void existing_btn_CheckedChanged(object sender, EventArgs e)
        {
            ShowAll(existing_btn.Checked);
        }

        #region Buttons
        private void proceed_btn_Click(object sender, EventArgs e)
        {
            // Validate the guest counts
            if (!ValidateGuestCounts())
            {
                return; // cannot proceed if validation fails
            }

            if (string.IsNullOrEmpty(roomDisplay.Text))
            {
                MessageBox.Show("Please select a room before proceeding.", "Room Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newGuest_btn.Enabled = true;
            existing_btn.Enabled = true;

            if (!newGuest_btn.Checked && !existing_btn.Checked)
            {
                newGuest_btn.Checked = true; // Default to new guest
            }

            ShowAll(newGuest_btn.Checked || existing_btn.Checked);

        }

        private void signin_Click(object sender, EventArgs e)
        {
            // Validate the ID number and guest counts
            if (!ValidateGuestDetails() || !ValidateGuestCounts())
            {
                return; // Stop the registration if the validation fails
            }

            guestController = new GuestController();
            PopulateGuestObject();
            guestController.DataMaintenance(aGuest, database.PhumlaKamnandiDB.DBOperation.Add);
            guestController.FinalizeChanges(aGuest);

            ClearAllFields();
            //MessageBox.Show("A guest is added");
            
            Booking newBooking = bookingController.CreateBooking(aGuest.ID, roomDisplay.Text, selectedAdult, selectedKids, dateTimePicker1.Value, dateTimePicker2.Value, ValidateRequests());

            Exit_done_button.Visible = true;

            listView2.Visible = true;

            Account account = new Account(accountController.GetAccountID(), aGuest.ID, card_tct.Text, exp_txt.Text);

            PrintConfirmation(newBooking);

            account.incrBalance(newBooking.Balance);

            bookingController.DataMaintenance(newBooking, database.PhumlaKamnandiDB.DBOperation.Add);
            //bookingController.
            bookingController.FinalizeChanges(newBooking);

            accountController.DataMaintenance(account, database.PhumlaKamnandiDB.DBOperation.Add);
            accountController.FinalizeChanges(account);

            HideAll(false);
        }

        private void serch_button_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dateTimePicker1.Value;
            DateTime checkOut = dateTimePicker2.Value;

            Collection<Room> avalRooms = bookingController.AvailableRooms(checkIn, checkOut);

            listView1.Items.Clear();

            foreach (Room room in avalRooms)
            {
                ListViewItem item = new ListViewItem(room.RoomNum);

                listView1.Items.Add(item);
            }
        }

        private void old_guest_signin_btn_Click(object sender, EventArgs e)
        {
            // Find if the ID of the guest does exist
            string guestID = signIn__idi_txt.Text;
            if (string.IsNullOrEmpty(guestID))
            {
                MessageBox.Show("Please enter a guest ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            aGuest = guestController.Find(guestID);
            if (aGuest == null)
            {
                MessageBox.Show("No guest found with this ID.", "Guest Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Booking newBooking = bookingController.CreateBooking(aGuest.ID, roomDisplay.Text, selectedAdult, selectedKids, dateTimePicker1.Value, dateTimePicker2.Value, ValidateRequests());

            Account account = accountController.Find(aGuest.ID);

            PrintConfirmation(newBooking);

            account.incrBalance(newBooking.Balance);

            bookingController.DataMaintenance(newBooking, database.PhumlaKamnandiDB.DBOperation.Add);
            bookingController.FinalizeChanges(newBooking);

            accountController.DataMaintenance(account, database.PhumlaKamnandiDB.DBOperation.Update);
            accountController.FinalizeChanges(account);

            HideAll(false);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Combo Box select (Adults and Children
        private void adults_txt_num_TextChanged_1(object sender, EventArgs e)
        {
            // Validate the input, ensuring only numbers are allowed
            if (int.TryParse(adults_txt_num.Text, out int adults))
            {
                selectedAdult = adults;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for adults.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                adults_txt_num.Clear();
            }
        }

        private void kids_txt_num_TextChanged_1(object sender, EventArgs e)
        {
            // Validate the input, ensuring only numbers are allowed
            if (int.TryParse(kids_txt_num.Text, out int kids))
            {
                selectedKids = kids;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for kids.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kids_txt_num.Clear();
            }
        }
        #endregion

        #region Room display text
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedRoomNumber = listView1.SelectedItems[0].Text;
                roomDisplay.Text = selectedRoomNumber;
            }
        }
        #endregion

        #region Validate

        private string ValidateRequests()
        {
            string requests = string.Empty;
            if (string.IsNullOrEmpty(request_txt.Text))
            {
                requests = "N/A";
            }
            else
            {
                requests = request_txt.Text;
            }
            return requests;
        }
        private bool ValidateGuestCounts()
        {
            // Validate Adults Count
            if (!int.TryParse(adults_txt_num.Text, out int adults) || adults < 1 || adults > 4)
            {
                MessageBox.Show("Please enter a valid number of adults (1 - 4).", "Invalid Adult Count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Kids Count
            if (!int.TryParse(kids_txt_num.Text, out int kids) || kids < 0 || kids > 3)
            {
                MessageBox.Show("Please enter a valid number of kids (0 - 3).", "Invalid Kids Count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check total count does not exceed limit
            int totalGuests = adults + kids;
            if (totalGuests > 4)
            {
                MessageBox.Show("The total number of guests (adults + kids) cannot exceed 4.", "Guest Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private bool ValidateID()
        {
            // Get the ID from the text box
            string idNumber = id_txt.Text;

            // Check if the ID is exactly 13 digits long and consists only of digits
            if (idNumber.Length != 13 || !idNumber.All(char.IsDigit))
            {
                MessageBox.Show("The ID number must be exactly 13 digits.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateFullName()
        {
            string fullName = name_txt.Text.Trim();

            // Split the name by spaces to check for both first and last name
            string[] nameParts = fullName.Split(' ');

            if (nameParts.Length < 2 || nameParts.Any(part => string.IsNullOrWhiteSpace(part)))
            {
                MessageBox.Show("Please enter a valid full name (first and last name).", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateCellNumber()
        {
            string cellNumber = cell_txt.Text.Trim();

            if (string.IsNullOrEmpty(cellNumber) || !cellNumber.All(char.IsDigit) || cellNumber.Length < 10)
            {
                MessageBox.Show("Please enter a valid cell number.", "Invalid Cell Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateEmail()
        {
            string email = email_txt.Text.Trim();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateCardNumber()
        {
            string cardNumber = card_tct.Text.Trim();

            if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
            {
                MessageBox.Show("The card number must be exactly 16 digits.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateExpiryDate()
        {
            string expiryDate = exp_txt.Text.Trim();
            DateTime parsedDate;

            // Check if the expiry date is in the correct format
            if (!DateTime.TryParseExact(expiryDate, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                MessageBox.Show("Please enter a valid expiry date (MM/YYYY).", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ensure the expiry date is in the future
            if (parsedDate < DateTime.Now)
            {
                MessageBox.Show("The expiry date must be in the future.", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateGuestDetails()
        {
            // Validate each field
            if (!ValidateFullName()) return false;
            if (!ValidateID()) return false;
            if (!ValidateCellNumber()) return false;
            if (!ValidateEmail()) return false;
            if (!ValidateCardNumber()) return false;
            if (!ValidateExpiryDate()) return false;

            // All validations passed
            return true;
        }
        #endregion

        #region Print Receipt
        private void PrintConfirmation(Booking newBooking)
        {
            Exit_done_button.Visible = true;

            listView2.Visible = true;

            ListViewItem item = new ListViewItem($"Booking ID: {newBooking.BookingID}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Guest ID: {newBooking.GuestID}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Room No: {newBooking.RoomNum}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Adults: {newBooking.NumAdults}, Children: {newBooking.NumChildren}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Check-In: {newBooking.CheckInDate.ToShortDateString()}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Check-Out: {newBooking.CheckOutDate.ToShortDateString()}\n\n ");
            listView2.Items.Add(item);

            item = new ListViewItem($"Special Request: {newBooking.SpecialRequest}");
            listView2.Items.Add(item);

            decimal bal = bookingController.CalculateCost(dateTimePicker1.Value, dateTimePicker2.Value);

            item = new ListViewItem($"Duration of stay: {(dateTimePicker2.Value - dateTimePicker1.Value).Days} day(s)");
            listView2.Items.Add(item);

            item = new ListViewItem($"Balance: R{bal}");
            listView2.Items.Add(item);
        }
        #endregion

        private void Exit_done_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
