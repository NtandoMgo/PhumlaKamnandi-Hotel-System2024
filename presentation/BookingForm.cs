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
        private Collection<Guest> guestCollection;
        private int selectedAdult = 1;
        private int selectedKids = 0;
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

            // Reset combo boxes for adults and kids
            adults_combo_select.SelectedIndex = -1; 
            kids_combo_select.SelectedIndex = -1; 

            // Clear room list view selection
            listView1.Items.Clear();

            // Hide confirmation text box
            confirmation_textBox.Clear();

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

            // Populate adults ComboBox
            adults_combo_select.Items.Clear();
            for (int i = 1; i <= 4; i++)
            {
                adults_combo_select.Items.Add(i.ToString());
            }

            // Populate kids ComboBox
            kids_combo_select.Items.Clear();
            for (int i = 0; i <4; i++)
            {
                kids_combo_select.Items.Add(i.ToString());
            }

            confirmation_textBox.Visible = false;
            confirmation_textBox.ReadOnly = true;
            Exit_done_button.Visible = false;

            newGuest_btn.Enabled = false;
            existing_btn.Enabled = false;
            ShowAll(false);

            roomDisplay.ReadOnly = true;
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
            // Check if at least 1 adult is selected
            if (adults_combo_select.SelectedItem == null || int.Parse(adults_combo_select.SelectedItem.ToString()) < 1)
            {
                MessageBox.Show("Please select at least 1 adult to proceed.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent further execution if no adult is selected
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
            // Validate the ID number
            if (!ValidateGuestDetails())
            {
                return; // Stop the registration if the validation fails
            }

            guestController = new GuestController();
            PopulateGuestObject();
            guestController.DataMaintenance(aGuest, database.PhumlaKamnandiDB.DBOperation.Add);
            guestController.FinalizeChanges(aGuest);

            ClearAllFields();
            //MessageBox.Show("A guest is added");
            Booking newBooking = bookingController.CreateBooking(aGuest.ID, roomDisplay.Text, selectedAdult, selectedKids, dateTimePicker1.Value, dateTimePicker2.Value, request_txt.Text);

            confirmation_textBox.Visible = true;
            Exit_done_button.Visible = true;

            confirmation_textBox.Text = $"Booking ID: {newBooking.BookingID}\n" +
                                $"Guest ID: {newBooking.GuestID}\n" +
                                $"Room No: {newBooking.RoomNum}\n" +
                                $"Adults: {newBooking.NumAdults}, Children: {newBooking.NumChildren}\n" +
                                $"Check-In: {newBooking.CheckInDate.ToShortDateString()}\n" +
                                $"Check-Out: {newBooking.CheckOutDate.ToShortDateString()}\n" +
                                $"Special Request: {newBooking.SpecialRequest}";

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
        #endregion

        #region Combo Box select (Adults and Children
        private void adults_combo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAdult = int.Parse(adults_combo_select.SelectedItem.ToString());

            int maxKids = 4 - selectedAdult;

            // Clear the items in the kids combo box and repopulate with valid options
            kids_combo_select.Items.Clear();
            for (int i = 0; i <= maxKids; i++)
            {
                kids_combo_select.Items.Add(i.ToString());
            }
            //kids_combo_select.SelectedIndex = 0;
        }

        private void kids_combo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKids = int.Parse(kids_combo_select.SelectedItem.ToString());

            int maxAdults = 4 - selectedKids;

            adults_combo_select.Items.Clear();
            for (int i = 1; i <= maxAdults; i++)
            {
                adults_combo_select.Items.Add(i.ToString());
            }
        }
        #endregion

        #region Rooms List View
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
    }
}
