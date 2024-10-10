using PhumlaKamnandi2024.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi2024.presentation
{
    public partial class OccupancyReportForm : Form
    {
        #region Data Fields
        private BookingController bookingController;
        #endregion

        #region Constructor & load
        public OccupancyReportForm()
        {
            InitializeComponent();
        }
        private void OccupancyReportForm_Load(object sender, EventArgs e)
        {
            //button1.Enabled = false;
            button4.Enabled = false;
            bookingController = new BookingController();

            DateTime today = DateTime.Now;
            checkInDate.MaxDate = today;
            checkOutDate.MaxDate = today;

            // Set MinDate to 12 months ago
            checkInDate.MinDate = today.AddMonths(-12);
            checkOutDate.MinDate = today.AddMonths(-12);
        }
        #endregion

        #region Cancel & Close Buttons
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Generate Report Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateDateSelection())
            {
                MessageBox.Show("Check In date must be before Check out date.");
                return;
            }
            
            DateTime startDate = checkInDate.Value;
            DateTime endDate = checkOutDate.Value;

            var occupancyData = GetOccupancyData(startDate, endDate);

            if (occupancyData.Count == 0)
            {
                MessageBox.Show("No occupancy data found for the selected date range. Please try a different range.",
                                "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if no data is found
            }

            button4.Enabled = occupancyData.Count > 0;
            DisplayOccupancyData(occupancyData);
        }
        #endregion

        #region Methods
        private List<OccupancyRecord> GetOccupancyData(DateTime startDate, DateTime endDate)
        {
            var records = new List<OccupancyRecord>();

            foreach (var booking in bookingController.GetAllBookings)
            {
                if (booking.CheckInDate < endDate && booking.CheckOutDate > startDate)
                {
                    records.Add(new OccupancyRecord
                    {
                        RoomNumber = booking.RoomNum,
                        GuestID = booking.GuestID,
                        CheckInDate = booking.CheckInDate,
                        CheckOutDate = booking.CheckOutDate,
                        DurationOfStay = (booking.CheckOutDate - booking.CheckInDate).Days
                    });
                }
            }
            return records;
        }

        private void DisplayOccupancyData(List<OccupancyRecord> records)
        {
            dataGridView1.DataSource = records.Select(r => new
            {
                r.RoomNumber,
                r.GuestID,
                r.CheckInDate,
                r.CheckOutDate,
                r.DurationOfStay
            }).ToList();
        }
        private bool ValidateDateSelection()
        {
            //button1.Enabled = checkInDate.Value < checkOutDate.Value;
            bool datesValidated = false;
            if (checkInDate.Value < checkOutDate.Value)
            {
                datesValidated = true;
            }
            return datesValidated;
        }
        #endregion

        #region Date Time pickers
        private void checkInDate_ValueChanged(object sender, EventArgs e)
        {
            //ValidateDateSelection();
        }

        private void checkOutDate_ValueChanged(object sender, EventArgs e)
        {
            //if (ValidateDateSelection())
            //{
            //    button1.Enabled = true;
            //}
            //else 
            //{
            //    MessageBox.Show("Check In date must be before Check out date.");
            //}
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A CSV file of this report will be emailed to you shortly.");
        }
    }

    public class OccupancyRecord
    {
        public string RoomNumber { get; set; }
        public string GuestID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int DurationOfStay { get; set; }
    }
}
