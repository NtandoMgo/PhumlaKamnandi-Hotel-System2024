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
    
    public partial class LogInForm : Form
    {
        #region Data Fields
        public bool IsAuthenticated { get; private set; } = false;
        ReceptionController receptionController;
        string emplId;
        #endregion

        #region Constructor
        public LogInForm()
        {
            InitializeComponent();
            receptionController = new ReceptionController();
        }
        #endregion

        #region Button
        private void button1_Click(object sender, EventArgs e)
        {
            string username = id_txt.Text;
            string password = pasword_txt.Text;

            if (receptionController.Authenticate(username, password))
            {
                IsAuthenticated = true;
                this.DialogResult = DialogResult.OK; // Indicate successful login

                var mdiParent = this.Owner as DashBoardMDIParent; // Assuming this form is owned by the MDI parent
                mdiParent?.SetLoggedInReceptionist(username); // Pass the ID to MDI parent

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
