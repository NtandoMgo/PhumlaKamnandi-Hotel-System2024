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
            this.components = new System.ComponentModel.Container();
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
            this.adults_lbl = new System.Windows.Forms.Label();
            this.kids_lbl = new System.Windows.Forms.Label();
            this.request_txt = new System.Windows.Forms.TextBox();
            this.requests_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkIn_lbl = new System.Windows.Forms.Label();
            this.checkOut_lbl = new System.Windows.Forms.Label();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Exit_done_button = new System.Windows.Forms.Button();
            this.roomDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.adults_txt_num = new System.Windows.Forms.TextBox();
            this.kids_txt_num = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // newGuest_btn
            // 
            this.newGuest_btn.AutoSize = true;
            this.newGuest_btn.Checked = true;
            this.newGuest_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuest_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGuest_btn.Location = new System.Drawing.Point(862, 140);
            this.newGuest_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newGuest_btn.Name = "newGuest_btn";
            this.newGuest_btn.Size = new System.Drawing.Size(144, 31);
            this.newGuest_btn.TabIndex = 0;
            this.newGuest_btn.TabStop = true;
            this.newGuest_btn.Text = "New Guest";
            this.newGuest_btn.UseVisualStyleBackColor = true;
            this.newGuest_btn.CheckedChanged += new System.EventHandler(this.newGuest_btn_CheckedChanged);
            // 
            // existing_btn
            // 
            this.existing_btn.AutoSize = true;
            this.existing_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existing_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.existing_btn.Location = new System.Drawing.Point(1138, 140);
            this.existing_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.existing_btn.Name = "existing_btn";
            this.existing_btn.Size = new System.Drawing.Size(186, 30);
            this.existing_btn.TabIndex = 1;
            this.existing_btn.Text = "Existing Guest";
            this.existing_btn.UseVisualStyleBackColor = true;
            this.existing_btn.CheckedChanged += new System.EventHandler(this.existing_btn_CheckedChanged);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_lbl.Location = new System.Drawing.Point(850, 265);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(113, 27);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Full name:";
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(1352, 768);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(134, 58);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.signin_Click);
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(1058, 238);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(288, 35);
            this.name_txt.TabIndex = 5;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id_lbl.Location = new System.Drawing.Point(856, 335);
            this.id_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(46, 26);
            this.id_lbl.TabIndex = 6;
            this.id_lbl.Text = "ID:";
            // 
            // cell_lbl
            // 
            this.cell_lbl.AutoSize = true;
            this.cell_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cell_lbl.Location = new System.Drawing.Point(850, 397);
            this.cell_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell_lbl.Name = "cell_lbl";
            this.cell_lbl.Size = new System.Drawing.Size(57, 27);
            this.cell_lbl.TabIndex = 7;
            this.cell_lbl.Text = "Cell:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email_lbl.Location = new System.Drawing.Point(850, 460);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(68, 27);
            this.email_lbl.TabIndex = 8;
            this.email_lbl.Text = "Email";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.address_lbl.Location = new System.Drawing.Point(850, 532);
            this.address_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(103, 26);
            this.address_lbl.TabIndex = 9;
            this.address_lbl.Text = "Address:";
            // 
            // card_no_lbl
            // 
            this.card_no_lbl.AutoSize = true;
            this.card_no_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_no_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.card_no_lbl.Location = new System.Drawing.Point(856, 638);
            this.card_no_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_no_lbl.Name = "card_no_lbl";
            this.card_no_lbl.Size = new System.Drawing.Size(144, 27);
            this.card_no_lbl.TabIndex = 10;
            this.card_no_lbl.Text = "Card number:";
            // 
            // exp_lbl
            // 
            this.exp_lbl.AutoSize = true;
            this.exp_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exp_lbl.Location = new System.Drawing.Point(856, 703);
            this.exp_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exp_lbl.Name = "exp_lbl";
            this.exp_lbl.Size = new System.Drawing.Size(130, 27);
            this.exp_lbl.TabIndex = 11;
            this.exp_lbl.Text = "Expiry date:";
            // 
            // cell_txt
            // 
            this.cell_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell_txt.Location = new System.Drawing.Point(1058, 391);
            this.cell_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cell_txt.Name = "cell_txt";
            this.cell_txt.Size = new System.Drawing.Size(206, 35);
            this.cell_txt.TabIndex = 12;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(1058, 455);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(324, 35);
            this.email_txt.TabIndex = 14;
            // 
            // addr_txt
            // 
            this.addr_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr_txt.Location = new System.Drawing.Point(1058, 528);
            this.addr_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addr_txt.Multiline = true;
            this.addr_txt.Name = "addr_txt";
            this.addr_txt.Size = new System.Drawing.Size(288, 84);
            this.addr_txt.TabIndex = 15;
            // 
            // card_tct
            // 
            this.card_tct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_tct.Location = new System.Drawing.Point(1058, 634);
            this.card_tct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.card_tct.Name = "card_tct";
            this.card_tct.Size = new System.Drawing.Size(278, 35);
            this.card_tct.TabIndex = 16;
            // 
            // exp_txt
            // 
            this.exp_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_txt.Location = new System.Drawing.Point(1058, 698);
            this.exp_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exp_txt.Name = "exp_txt";
            this.exp_txt.Size = new System.Drawing.Size(126, 35);
            this.exp_txt.TabIndex = 17;
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(1058, 331);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(288, 35);
            this.id_txt.TabIndex = 18;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // old_guest_signin_btn
            // 
            this.old_guest_signin_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_guest_signin_btn.Location = new System.Drawing.Point(1052, 471);
            this.old_guest_signin_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.old_guest_signin_btn.Name = "old_guest_signin_btn";
            this.old_guest_signin_btn.Size = new System.Drawing.Size(134, 58);
            this.old_guest_signin_btn.TabIndex = 19;
            this.old_guest_signin_btn.Text = "Sign In";
            this.old_guest_signin_btn.UseVisualStyleBackColor = true;
            this.old_guest_signin_btn.Click += new System.EventHandler(this.old_guest_signin_btn_Click);
            // 
            // signIn__idi_txt
            // 
            this.signIn__idi_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn__idi_txt.Location = new System.Drawing.Point(1058, 331);
            this.signIn__idi_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signIn__idi_txt.Name = "signIn__idi_txt";
            this.signIn__idi_txt.Size = new System.Drawing.Size(250, 35);
            this.signIn__idi_txt.TabIndex = 20;
            // 
            // signin_Id_lbl
            // 
            this.signin_Id_lbl.AutoSize = true;
            this.signin_Id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_Id_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signin_Id_lbl.Location = new System.Drawing.Point(1006, 335);
            this.signin_Id_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signin_Id_lbl.Name = "signin_Id_lbl";
            this.signin_Id_lbl.Size = new System.Drawing.Size(43, 27);
            this.signin_Id_lbl.TabIndex = 21;
            this.signin_Id_lbl.Text = "ID:";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(18, 768);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(134, 58);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 197);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 209);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // serch_button
            // 
            this.serch_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serch_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.serch_button.Location = new System.Drawing.Point(176, 135);
            this.serch_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serch_button.Name = "serch_button";
            this.serch_button.Size = new System.Drawing.Size(273, 40);
            this.serch_button.TabIndex = 27;
            this.serch_button.Text = "Search Available Rooms";
            this.serch_button.UseVisualStyleBackColor = true;
            this.serch_button.Click += new System.EventHandler(this.serch_button_Click);
            // 
            // adults_lbl
            // 
            this.adults_lbl.AutoSize = true;
            this.adults_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adults_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adults_lbl.Location = new System.Drawing.Point(69, 500);
            this.adults_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adults_lbl.Name = "adults_lbl";
            this.adults_lbl.Size = new System.Drawing.Size(87, 26);
            this.adults_lbl.TabIndex = 29;
            this.adults_lbl.Text = "Adults:";
            // 
            // kids_lbl
            // 
            this.kids_lbl.AutoSize = true;
            this.kids_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kids_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kids_lbl.Location = new System.Drawing.Point(270, 500);
            this.kids_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kids_lbl.Name = "kids_lbl";
            this.kids_lbl.Size = new System.Drawing.Size(62, 27);
            this.kids_lbl.TabIndex = 30;
            this.kids_lbl.Text = "Kids:";
            // 
            // request_txt
            // 
            this.request_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_txt.Location = new System.Drawing.Point(276, 580);
            this.request_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.request_txt.Multiline = true;
            this.request_txt.Name = "request_txt";
            this.request_txt.Size = new System.Drawing.Size(288, 132);
            this.request_txt.TabIndex = 32;
            // 
            // requests_lbl
            // 
            this.requests_lbl.AutoSize = true;
            this.requests_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requests_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.requests_lbl.Location = new System.Drawing.Point(69, 585);
            this.requests_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requests_lbl.Name = "requests_lbl";
            this.requests_lbl.Size = new System.Drawing.Size(191, 26);
            this.requests_lbl.TabIndex = 33;
            this.requests_lbl.Text = "Special Requests:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 78);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 26);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 78);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // checkIn_lbl
            // 
            this.checkIn_lbl.AutoSize = true;
            this.checkIn_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkIn_lbl.Location = new System.Drawing.Point(69, 31);
            this.checkIn_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkIn_lbl.Name = "checkIn_lbl";
            this.checkIn_lbl.Size = new System.Drawing.Size(201, 27);
            this.checkIn_lbl.TabIndex = 36;
            this.checkIn_lbl.Text = "Pick Check In Date";
            // 
            // checkOut_lbl
            // 
            this.checkOut_lbl.AutoSize = true;
            this.checkOut_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkOut_lbl.Location = new System.Drawing.Point(396, 31);
            this.checkOut_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkOut_lbl.Name = "checkOut_lbl";
            this.checkOut_lbl.Size = new System.Drawing.Size(217, 27);
            this.checkOut_lbl.TabIndex = 37;
            this.checkOut_lbl.Text = "Pick Check Out Date";
            // 
            // proceed_btn
            // 
            this.proceed_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.Location = new System.Drawing.Point(432, 768);
            this.proceed_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(134, 58);
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
            // Exit_done_button
            // 
            this.Exit_done_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_done_button.Location = new System.Drawing.Point(873, 768);
            this.Exit_done_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit_done_button.Name = "Exit_done_button";
            this.Exit_done_button.Size = new System.Drawing.Size(134, 58);
            this.Exit_done_button.TabIndex = 40;
            this.Exit_done_button.Text = "Done";
            this.Exit_done_button.UseVisualStyleBackColor = true;
            this.Exit_done_button.Click += new System.EventHandler(this.Exit_done_button_Click);
            // 
            // roomDisplay
            // 
            this.roomDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDisplay.Location = new System.Drawing.Point(276, 417);
            this.roomDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomDisplay.Name = "roomDisplay";
            this.roomDisplay.Size = new System.Drawing.Size(92, 35);
            this.roomDisplay.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Selected Room:";
            // 
            // adults_txt_num
            // 
            this.adults_txt_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adults_txt_num.Location = new System.Drawing.Point(147, 489);
            this.adults_txt_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adults_txt_num.Name = "adults_txt_num";
            this.adults_txt_num.Size = new System.Drawing.Size(54, 35);
            this.adults_txt_num.TabIndex = 43;
            this.adults_txt_num.TextChanged += new System.EventHandler(this.adults_txt_num_TextChanged_1);
            // 
            // kids_txt_num
            // 
            this.kids_txt_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kids_txt_num.Location = new System.Drawing.Point(340, 489);
            this.kids_txt_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kids_txt_num.Name = "kids_txt_num";
            this.kids_txt_num.Size = new System.Drawing.Size(58, 35);
            this.kids_txt_num.TabIndex = 44;
            this.kids_txt_num.TextChanged += new System.EventHandler(this.kids_txt_num_TextChanged_1);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(597, 197);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(511, 319);
            this.listView2.TabIndex = 45;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1550, 845);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.kids_txt_num);
            this.Controls.Add(this.adults_txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomDisplay);
            this.Controls.Add(this.Exit_done_button);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.checkOut_lbl);
            this.Controls.Add(this.checkIn_lbl);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.requests_lbl);
            this.Controls.Add(this.request_txt);
            this.Controls.Add(this.kids_lbl);
            this.Controls.Add(this.adults_lbl);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label adults_lbl;
        private System.Windows.Forms.Label kids_lbl;
        private System.Windows.Forms.TextBox request_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label checkIn_lbl;
        private System.Windows.Forms.Label checkOut_lbl;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button Exit_done_button;
        private System.Windows.Forms.Label requests_lbl;
        private System.Windows.Forms.TextBox roomDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox adults_txt_num;
        private System.Windows.Forms.TextBox kids_txt_num;
        private System.Windows.Forms.ListView listView2;
    }
}