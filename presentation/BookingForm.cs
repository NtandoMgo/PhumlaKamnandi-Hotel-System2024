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
            //guestController = new GuestController();
        }
    }
}
