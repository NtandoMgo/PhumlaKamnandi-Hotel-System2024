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
    public partial class DashBoardMDIParent : Form
    {
        #region data Fields
        private int childFormNumber = 0;
        private BookingForm bookingForm;
        private GuestListViewForm guestListViewForm;
        private BookingListingForm bookingListingForm;
        private AccountsListingForm accountsListingForm;
        private LogInForm logInForm;

        private bool isLoggedIn = false;

        private string loggedInReceptionistId;
        #endregion

        public DashBoardMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guestListViewForm = new GuestListViewForm();
            guestListViewForm.ShowDialog();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingListingForm = new BookingListingForm();
            bookingListingForm.ShowDialog();   
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountsListingForm = new AccountsListingForm();
            accountsListingForm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logInForm = new LogInForm();
            //logInForm = new LogInForm();
            //if (logInForm.ShowDialog() == DialogResult.OK && logInForm.IsAuthenticated)
            //{
            //    isLoggedIn = true;
            //    UpdateMenuItems();
            //}

            if (isLoggedIn)
            {
                // If logged in, log out
                isLoggedIn = false;
                loginToolStripMenuItem.Text = "Login"; // Change text to Login
                loginToolStripMenuItem.ForeColor = Color.Green;

                Logout();

                UpdateMenuItems();
            }
            else
            {
                logInForm = new LogInForm();
                if (logInForm.ShowDialog() == DialogResult.OK && logInForm.IsAuthenticated)
                {
                    isLoggedIn = true;
                    loginToolStripMenuItem.Text = "Logout";
                    loginToolStripMenuItem.ForeColor = Color.Red;
                    UpdateMenuItems();
                }
            }
        }

        #region methods
        private void UpdateMenuItems()
        {
            bookingToolStripMenuItem.Enabled = isLoggedIn;
            viewToolStripMenuItem.Enabled = isLoggedIn;

            if (isLoggedIn)
            {
                stat_lbl.Text = $"Logged in as: "+loggedInReceptionistId;
            }
            else
            {
                stat_lbl.Text = "Not logged in";
            }

            //loginToolStripMenuItem.Enabled = !isLoggedIn; // Disable login if already logged in
        }
        #endregion

        private void DashBoardMDIParent_Load(object sender, EventArgs e)
        {
            UpdateMenuItems();
        }
        private void Logout()
        {
            isLoggedIn = false;
            UpdateMenuItems();
        }

        public void SetLoggedInReceptionist(string receptionistId)
        {
            loggedInReceptionistId = receptionistId;
            UpdateMenuItems();
        }

        private void stat_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
