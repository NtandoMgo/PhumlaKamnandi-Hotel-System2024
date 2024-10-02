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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhumlaKamnandi2024.presentation
{
    public partial class GuestListViewForm : Form
    {
        #region Data Fields
        private GuestController guestController;
        private Collection<Guest> guestCollection;

        private enum FormState
        {
            View,
            Edit
        }

        private FormState currentState;
        #endregion
        public GuestListViewForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            LoadGuests();
        }

        #region Methods
        private void LoadGuests()
        {
            guestCollection = guestController.AllGuests;
            guestsDataGridView.DataSource = guestCollection; // Bind the collection to the DataGridView

            // Set ID column as read-only
            guestsDataGridView.Columns["ID"].ReadOnly = true;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            id_txt.Visible = value;
            textBox2.Visible = value;
            textBox3.Visible = value;
            textBox4.Visible = value;
            textBox5.Visible = value;
            textBox6.Visible = value;
            textBox7.Visible = value;

            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label5.Visible = value;
            label6.Visible = value;
            label7.Visible = value;
            name_lbl.Visible = value;

            update_button.Visible = value;
            edit_btn.Visible = !value;

            guestsDataGridView.Enabled = value;
        }

        private void ClearAll()
        {
            id_txt.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
        #endregion

        #region Click Events
        private void GuestListViewForm_Load(object sender, EventArgs e)
        {
            currentState = FormState.View;
            ShowAll(false);
            id_txt.ReadOnly = true;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            currentState = FormState.Edit;
            ShowAll(true);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            ClearAll();
            currentState = FormState.View;
            ShowAll(false);
        }

        private void guestsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && currentState == FormState.Edit)
            {
                // Retrieve selected guest data
                DataGridViewRow selectedRow = guestsDataGridView.Rows[e.RowIndex];
                textBox2.Text = selectedRow.Cells["Email"].Value.ToString();
                id_txt.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Cell"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
