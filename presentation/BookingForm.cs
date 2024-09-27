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

        #endregion
        public BookingForm()
        {
            InitializeComponent();
        }

        #region Buttons
        private void signin_Click(object sender, EventArgs e)
        {
            guestController = new GuestController();
            PopulateGuestObject();
            guestController.DataMaintenance(aGuest, database.PhumlaKamnandiDB.DBOperation.Add);
            guestController.FinalizeChanges(aGuest);

            MessageBox.Show("A guest is added");
        }
        #endregion

        private void BookingForm_Load(object sender, EventArgs e)
        {
            bookingController = new BookingController();
            guestController = new GuestController();
            //newGuest_btn.Checked = false;
            //existing_btn.Checked = false;
            confirmation_textBox.Visible = false;

            newGuest_btn.Enabled = false;
            existing_btn.Enabled = false;
            ShowAll(false);
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
            newGuest_btn.Enabled = true;
            existing_btn.Enabled = true;

            if (!newGuest_btn.Checked && !existing_btn.Checked)
            {
                newGuest_btn.Checked = true; // Default to new guest
            }

            ShowAll(newGuest_btn.Checked || existing_btn.Checked);

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
    }
}
