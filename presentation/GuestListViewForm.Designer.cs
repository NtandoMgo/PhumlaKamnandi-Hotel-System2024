namespace PhumlaKamnandi2024.presentation
{
    partial class GuestListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guestsDataGridView = new System.Windows.Forms.DataGridView();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guestsDataGridView
            // 
            this.guestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.guestsDataGridView.Name = "guestsDataGridView";
            this.guestsDataGridView.Size = new System.Drawing.Size(481, 150);
            this.guestsDataGridView.TabIndex = 0;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(418, 223);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(418, 342);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 2;
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // GuestListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.guestsDataGridView);
            this.Name = "GuestListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GuestListViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guestsDataGridView;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
    }
}