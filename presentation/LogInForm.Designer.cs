namespace PhumlaKamnandi2024.presentation
{
    partial class LogInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.pasword_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(364, 150);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(128, 26);
            this.id_txt.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(265, 208);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(72, 19);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password:";
            // 
            // pasword_txt
            // 
            this.pasword_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasword_txt.Location = new System.Drawing.Point(364, 205);
            this.pasword_txt.Name = "pasword_txt";
            this.pasword_txt.Size = new System.Drawing.Size(100, 26);
            this.pasword_txt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pasword_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label1);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox pasword_txt;
        private System.Windows.Forms.Button button1;
    }
}