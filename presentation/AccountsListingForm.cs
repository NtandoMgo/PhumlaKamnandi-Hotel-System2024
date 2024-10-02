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
    
    public partial class AccountsListingForm : Form
    {
        #region Data Fields
        AccountController accountController;
        Collection<Account> accounts;
        #endregion
        public AccountsListingForm()
        {
            InitializeComponent();
            accountController = new AccountController();
            accounts = accountController.AllAccounts;

            dataGridView1.DataSource = accounts;
            dataGridView1.ReadOnly = true;

        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string guestId = find_acc_txt.Text;



            if (guestId.Length != 13 || !long.TryParse(guestId, out _))
            {
                MessageBox.Show("Please enter a valid ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reset row highlighting
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor; // Reset to default
            }

            bool found = false; // Flag to track if the account is found

            // Find and highlight the row
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["GuestID"].Value != null && row.Cells["GuestID"].Value.ToString() == guestId)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.CurrentCell = row.Cells[0]; 
                    found = true;
                    break; // Stop searching after the first match
                }
            }

            if (!found)
            {
                MessageBox.Show("No guest found with the provided Guest ID.", "Guest Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
