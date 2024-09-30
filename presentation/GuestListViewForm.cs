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
    public partial class GuestListViewForm : Form
    {
        #region Data Fields
        private GuestController guestController;
        private Collection<Guest> guestCollection;
        #endregion
        public GuestListViewForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            LoadGuests();
        }

        #region
        private void LoadGuests()
        {
            guestCollection = guestController.AllGuests;
            guestsDataGridView.DataSource = guestCollection; // Bind the collection to the DataGridView

            // Set ID column as read-only
            guestsDataGridView.Columns["ID"].ReadOnly = true;
        }
        #endregion
    }
}
