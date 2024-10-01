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
        #endregion
        public BookingListingForm()
        {
            InitializeComponent();
            bookingController = new BookingController();

            bookings = bookingController.GetAllBookings;

            bookingsDataGridView.DataSource = bookings;
            bookingsDataGridView.Columns["BookingID"].ReadOnly = true;
            bookingsDataGridView.Columns["GuestID"].ReadOnly = true ;
            bookingsDataGridView.Columns["RoomNum"].ReadOnly = true;
        }
    }
}
