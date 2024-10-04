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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestListViewForm));
            this.guestsDataGridView = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.exp_date_txt = new System.Windows.Forms.TextBox();
            this.card_num_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guestsDataGridView
            // 
            this.guestsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guestsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsDataGridView.Location = new System.Drawing.Point(70, 58);
            this.guestsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestsDataGridView.Name = "guestsDataGridView";
            this.guestsDataGridView.RowHeadersWidth = 62;
            this.guestsDataGridView.Size = new System.Drawing.Size(828, 311);
            this.guestsDataGridView.TabIndex = 0;
            this.guestsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsDataGridView_CellContentClick);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(792, 766);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(120, 57);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.Location = new System.Drawing.Point(406, 394);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(154, 74);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(240, 412);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(163, 35);
            this.id_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(241, 557);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(232, 35);
            this.email_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(240, 497);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(319, 35);
            this.name_txt.TabIndex = 5;
            // 
            // address_txt
            // 
            this.address_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txt.Location = new System.Drawing.Point(240, 678);
            this.address_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(232, 66);
            this.address_txt.TabIndex = 6;
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(240, 614);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(163, 35);
            this.phone_txt.TabIndex = 7;
            // 
            // exp_date_txt
            // 
            this.exp_date_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_date_txt.Location = new System.Drawing.Point(734, 631);
            this.exp_date_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exp_date_txt.Name = "exp_date_txt";
            this.exp_date_txt.Size = new System.Drawing.Size(163, 35);
            this.exp_date_txt.TabIndex = 8;
            // 
            // card_num_txt
            // 
            this.card_num_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_num_txt.Location = new System.Drawing.Point(734, 571);
            this.card_num_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.card_num_txt.Name = "card_num_txt";
            this.card_num_txt.Size = new System.Drawing.Size(163, 35);
            this.card_num_txt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(590, 580);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(117, 616);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(117, 566);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_lbl.Location = new System.Drawing.Point(119, 497);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(79, 26);
            this.name_lbl.TabIndex = 13;
            this.name_lbl.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(590, 631);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Exp Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(114, 683);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(698, 502);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Account Details";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(70, 766);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(120, 57);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // GuestListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 843);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card_num_txt);
            this.Controls.Add(this.exp_date_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.guestsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GuestListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GuestListViewForm";
            this.Load += new System.EventHandler(this.GuestListViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView guestsDataGridView;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox exp_date_txt;
        private System.Windows.Forms.TextBox card_num_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelbutton;
    }
}