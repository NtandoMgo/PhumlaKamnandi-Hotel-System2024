namespace PhumlaKamnandi2024.presentation
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.newGuest_btn = new System.Windows.Forms.RadioButton();
            this.existing_btn = new System.Windows.Forms.RadioButton();
            this.name_lbl = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.cell_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.card_no_lbl = new System.Windows.Forms.Label();
            this.exp_lbl = new System.Windows.Forms.Label();
            this.cell_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.addr_txt = new System.Windows.Forms.TextBox();
            this.card_tct = new System.Windows.Forms.TextBox();
            this.exp_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.old_guest_signin_btn = new System.Windows.Forms.Button();
            this.signIn__idi_txt = new System.Windows.Forms.TextBox();
            this.signin_Id_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.serch_button = new System.Windows.Forms.Button();
            this.adults_combo_select = new System.Windows.Forms.ComboBox();
            this.adults_lbl = new System.Windows.Forms.Label();
            this.kids_lbl = new System.Windows.Forms.Label();
            this.kids_combo_select = new System.Windows.Forms.ComboBox();
            this.request_txt = new System.Windows.Forms.TextBox();
            this.requests_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkIn_lbl = new System.Windows.Forms.Label();
            this.checkOut_lbl = new System.Windows.Forms.Label();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.confirmation_textBox = new System.Windows.Forms.TextBox();
            this.Exit_done_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGuest_btn
            // 
            this.newGuest_btn.AutoSize = true;
            this.newGuest_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuest_btn.Location = new System.Drawing.Point(575, 91);
            this.newGuest_btn.Name = "newGuest_btn";
            this.newGuest_btn.Size = new System.Drawing.Size(96, 23);
            this.newGuest_btn.TabIndex = 0;
            this.newGuest_btn.TabStop = true;
            this.newGuest_btn.Text = "New Guest";
            this.newGuest_btn.UseVisualStyleBackColor = true;
            this.newGuest_btn.CheckedChanged += new System.EventHandler(this.newGuest_btn_CheckedChanged);
            // 
            // existing_btn
            // 
            this.existing_btn.AutoSize = true;
            this.existing_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existing_btn.Location = new System.Drawing.Point(759, 91);
            this.existing_btn.Name = "existing_btn";
            this.existing_btn.Size = new System.Drawing.Size(112, 23);
            this.existing_btn.TabIndex = 1;
            this.existing_btn.TabStop = true;
            this.existing_btn.Text = "Existing Guest";
            this.existing_btn.UseVisualStyleBackColor = true;
            this.existing_btn.CheckedChanged += new System.EventHandler(this.existing_btn_CheckedChanged);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(567, 172);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(70, 19);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Full name:";
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(901, 499);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(89, 38);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.signin_Click);
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(705, 155);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(193, 26);
            this.name_txt.TabIndex = 5;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(571, 218);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(28, 19);
            this.id_lbl.TabIndex = 6;
            this.id_lbl.Text = "ID:";
            // 
            // cell_lbl
            // 
            this.cell_lbl.AutoSize = true;
            this.cell_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell_lbl.Location = new System.Drawing.Point(567, 258);
            this.cell_lbl.Name = "cell_lbl";
            this.cell_lbl.Size = new System.Drawing.Size(36, 19);
            this.cell_lbl.TabIndex = 7;
            this.cell_lbl.Text = "Cell:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(567, 299);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(42, 19);
            this.email_lbl.TabIndex = 8;
            this.email_lbl.Text = "Email";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(567, 346);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(63, 19);
            this.address_lbl.TabIndex = 9;
            this.address_lbl.Text = "Address:";
            // 
            // card_no_lbl
            // 
            this.card_no_lbl.AutoSize = true;
            this.card_no_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_no_lbl.Location = new System.Drawing.Point(571, 415);
            this.card_no_lbl.Name = "card_no_lbl";
            this.card_no_lbl.Size = new System.Drawing.Size(92, 19);
            this.card_no_lbl.TabIndex = 10;
            this.card_no_lbl.Text = "Card number:";
            // 
            // exp_lbl
            // 
            this.exp_lbl.AutoSize = true;
            this.exp_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_lbl.Location = new System.Drawing.Point(571, 457);
            this.exp_lbl.Name = "exp_lbl";
            this.exp_lbl.Size = new System.Drawing.Size(81, 19);
            this.exp_lbl.TabIndex = 11;
            this.exp_lbl.Text = "Expiry date:";
            // 
            // cell_txt
            // 
            this.cell_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell_txt.Location = new System.Drawing.Point(705, 254);
            this.cell_txt.Name = "cell_txt";
            this.cell_txt.Size = new System.Drawing.Size(139, 26);
            this.cell_txt.TabIndex = 12;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(705, 296);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(217, 26);
            this.email_txt.TabIndex = 14;
            // 
            // addr_txt
            // 
            this.addr_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr_txt.Location = new System.Drawing.Point(705, 343);
            this.addr_txt.Multiline = true;
            this.addr_txt.Name = "addr_txt";
            this.addr_txt.Size = new System.Drawing.Size(193, 56);
            this.addr_txt.TabIndex = 15;
            // 
            // card_tct
            // 
            this.card_tct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_tct.Location = new System.Drawing.Point(705, 412);
            this.card_tct.Name = "card_tct";
            this.card_tct.Size = new System.Drawing.Size(187, 26);
            this.card_tct.TabIndex = 16;
            // 
            // exp_txt
            // 
            this.exp_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_txt.Location = new System.Drawing.Point(705, 454);
            this.exp_txt.Name = "exp_txt";
            this.exp_txt.Size = new System.Drawing.Size(85, 26);
            this.exp_txt.TabIndex = 17;
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(705, 215);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(193, 26);
            this.id_txt.TabIndex = 18;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // old_guest_signin_btn
            // 
            this.old_guest_signin_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_guest_signin_btn.Location = new System.Drawing.Point(795, 336);
            this.old_guest_signin_btn.Name = "old_guest_signin_btn";
            this.old_guest_signin_btn.Size = new System.Drawing.Size(89, 38);
            this.old_guest_signin_btn.TabIndex = 19;
            this.old_guest_signin_btn.Text = "Sign In";
            this.old_guest_signin_btn.UseVisualStyleBackColor = true;
            // 
            // signIn__idi_txt
            // 
            this.signIn__idi_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn__idi_txt.Location = new System.Drawing.Point(795, 223);
            this.signIn__idi_txt.Name = "signIn__idi_txt";
            this.signIn__idi_txt.Size = new System.Drawing.Size(168, 26);
            this.signIn__idi_txt.TabIndex = 20;
            // 
            // signin_Id_lbl
            // 
            this.signin_Id_lbl.AutoSize = true;
            this.signin_Id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_Id_lbl.Location = new System.Drawing.Point(744, 223);
            this.signin_Id_lbl.Name = "signin_Id_lbl";
            this.signin_Id_lbl.Size = new System.Drawing.Size(28, 19);
            this.signin_Id_lbl.TabIndex = 21;
            this.signin_Id_lbl.Text = "ID:";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 499);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(89, 38);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 159);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // serch_button
            // 
            this.serch_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serch_button.Location = new System.Drawing.Point(117, 88);
            this.serch_button.Name = "serch_button";
            this.serch_button.Size = new System.Drawing.Size(182, 26);
            this.serch_button.TabIndex = 27;
            this.serch_button.Text = "Search Available Rooms";
            this.serch_button.UseVisualStyleBackColor = true;
            this.serch_button.Click += new System.EventHandler(this.serch_button_Click);
            // 
            // adults_combo_select
            // 
            this.adults_combo_select.FormattingEnabled = true;
            this.adults_combo_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.adults_combo_select.Location = new System.Drawing.Point(117, 325);
            this.adults_combo_select.Name = "adults_combo_select";
            this.adults_combo_select.Size = new System.Drawing.Size(53, 21);
            this.adults_combo_select.TabIndex = 28;
            // 
            // adults_lbl
            // 
            this.adults_lbl.AutoSize = true;
            this.adults_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adults_lbl.Location = new System.Drawing.Point(46, 325);
            this.adults_lbl.Name = "adults_lbl";
            this.adults_lbl.Size = new System.Drawing.Size(51, 19);
            this.adults_lbl.TabIndex = 29;
            this.adults_lbl.Text = "Adults:";
            // 
            // kids_lbl
            // 
            this.kids_lbl.AutoSize = true;
            this.kids_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kids_lbl.Location = new System.Drawing.Point(225, 325);
            this.kids_lbl.Name = "kids_lbl";
            this.kids_lbl.Size = new System.Drawing.Size(41, 19);
            this.kids_lbl.TabIndex = 30;
            this.kids_lbl.Text = "Kids:";
            // 
            // kids_combo_select
            // 
            this.kids_combo_select.FormattingEnabled = true;
            this.kids_combo_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "0"});
            this.kids_combo_select.Location = new System.Drawing.Point(284, 323);
            this.kids_combo_select.Name = "kids_combo_select";
            this.kids_combo_select.Size = new System.Drawing.Size(53, 21);
            this.kids_combo_select.TabIndex = 31;
            // 
            // request_txt
            // 
            this.request_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_txt.Location = new System.Drawing.Point(184, 377);
            this.request_txt.Multiline = true;
            this.request_txt.Name = "request_txt";
            this.request_txt.Size = new System.Drawing.Size(193, 87);
            this.request_txt.TabIndex = 32;
            // 
            // requests_lbl
            // 
            this.requests_lbl.AutoSize = true;
            this.requests_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requests_lbl.Location = new System.Drawing.Point(46, 380);
            this.requests_lbl.Name = "requests_lbl";
            this.requests_lbl.Size = new System.Drawing.Size(115, 19);
            this.requests_lbl.TabIndex = 33;
            this.requests_lbl.Text = "Special Requests:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(229, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // checkIn_lbl
            // 
            this.checkIn_lbl.AutoSize = true;
            this.checkIn_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_lbl.Location = new System.Drawing.Point(46, 20);
            this.checkIn_lbl.Name = "checkIn_lbl";
            this.checkIn_lbl.Size = new System.Drawing.Size(129, 19);
            this.checkIn_lbl.TabIndex = 36;
            this.checkIn_lbl.Text = "Pick Check In Date";
            // 
            // checkOut_lbl
            // 
            this.checkOut_lbl.AutoSize = true;
            this.checkOut_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_lbl.Location = new System.Drawing.Point(264, 20);
            this.checkOut_lbl.Name = "checkOut_lbl";
            this.checkOut_lbl.Size = new System.Drawing.Size(140, 19);
            this.checkOut_lbl.TabIndex = 37;
            this.checkOut_lbl.Text = "Pick Check Out Date";
            // 
            // proceed_btn
            // 
            this.proceed_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.Location = new System.Drawing.Point(288, 499);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(89, 38);
            this.proceed_btn.TabIndex = 38;
            this.proceed_btn.Text = "Proceed";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // confirmation_textBox
            // 
            this.confirmation_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation_textBox.Location = new System.Drawing.Point(288, 120);
            this.confirmation_textBox.Multiline = true;
            this.confirmation_textBox.Name = "confirmation_textBox";
            this.confirmation_textBox.Size = new System.Drawing.Size(424, 213);
            this.confirmation_textBox.TabIndex = 39;
            // 
            // Exit_done_button
            // 
            this.Exit_done_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_done_button.Location = new System.Drawing.Point(582, 499);
            this.Exit_done_button.Name = "Exit_done_button";
            this.Exit_done_button.Size = new System.Drawing.Size(89, 38);
            this.Exit_done_button.TabIndex = 40;
            this.Exit_done_button.Text = "Done";
            this.Exit_done_button.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 549);
            this.Controls.Add(this.Exit_done_button);
            this.Controls.Add(this.confirmation_textBox);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.checkOut_lbl);
            this.Controls.Add(this.checkIn_lbl);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.requests_lbl);
            this.Controls.Add(this.request_txt);
            this.Controls.Add(this.kids_combo_select);
            this.Controls.Add(this.kids_lbl);
            this.Controls.Add(this.adults_lbl);
            this.Controls.Add(this.adults_combo_select);
            this.Controls.Add(this.serch_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.signin_Id_lbl);
            this.Controls.Add(this.signIn__idi_txt);
            this.Controls.Add(this.old_guest_signin_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.exp_txt);
            this.Controls.Add(this.card_tct);
            this.Controls.Add(this.addr_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.cell_txt);
            this.Controls.Add(this.exp_lbl);
            this.Controls.Add(this.card_no_lbl);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.cell_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.existing_btn);
            this.Controls.Add(this.newGuest_btn);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton newGuest_btn;
        private System.Windows.Forms.RadioButton existing_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label cell_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label card_no_lbl;
        private System.Windows.Forms.Label exp_lbl;
        private System.Windows.Forms.TextBox cell_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox addr_txt;
        private System.Windows.Forms.TextBox card_tct;
        private System.Windows.Forms.TextBox exp_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button old_guest_signin_btn;
        private System.Windows.Forms.TextBox signIn__idi_txt;
        private System.Windows.Forms.Label signin_Id_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button serch_button;
        private System.Windows.Forms.ComboBox adults_combo_select;
        private System.Windows.Forms.Label adults_lbl;
        private System.Windows.Forms.Label kids_lbl;
        private System.Windows.Forms.ComboBox kids_combo_select;
        private System.Windows.Forms.TextBox request_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label checkIn_lbl;
        private System.Windows.Forms.Label checkOut_lbl;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox confirmation_textBox;
        private System.Windows.Forms.Button Exit_done_button;
        private System.Windows.Forms.Label requests_lbl;
    }
}