
namespace MyDiary
{
    partial class Signup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Namelabel1 = new System.Windows.Forms.Label();
            this.Confirmbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasslabel = new System.Windows.Forms.Label();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Emailbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Emaillabel);
            this.groupBox1.Controls.Add(this.Confirmbox);
            this.groupBox1.Controls.Add(this.ConfirmPasslabel);
            this.groupBox1.Controls.Add(this.Namebox);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.Passwordlabel);
            this.groupBox1.Controls.Add(this.Namelabel1);
            this.groupBox1.Location = new System.Drawing.Point(334, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 348);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(160, 49);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(206, 26);
            this.Namebox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(160, 99);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(206, 26);
            this.PasswordBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(189, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Passwordlabel.Location = new System.Drawing.Point(52, 102);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(78, 20);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password";
            // 
            // Namelabel1
            // 
            this.Namelabel1.AutoSize = true;
            this.Namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Namelabel1.Location = new System.Drawing.Point(64, 55);
            this.Namelabel1.Name = "Namelabel1";
            this.Namelabel1.Size = new System.Drawing.Size(51, 20);
            this.Namelabel1.TabIndex = 3;
            this.Namelabel1.Text = "Name";
            // 
            // Confirmbox
            // 
            this.Confirmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbox.Location = new System.Drawing.Point(160, 147);
            this.Confirmbox.Name = "Confirmbox";
            this.Confirmbox.PasswordChar = '*';
            this.Confirmbox.Size = new System.Drawing.Size(206, 26);
            this.Confirmbox.TabIndex = 5;
            // 
            // ConfirmPasslabel
            // 
            this.ConfirmPasslabel.AutoSize = true;
            this.ConfirmPasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmPasslabel.Location = new System.Drawing.Point(18, 150);
            this.ConfirmPasslabel.Name = "ConfirmPasslabel";
            this.ConfirmPasslabel.Size = new System.Drawing.Size(137, 20);
            this.ConfirmPasslabel.TabIndex = 6;
            this.ConfirmPasslabel.Text = "Confirm Password";
            // 
            // Emailbox
            // 
            this.Emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailbox.Location = new System.Drawing.Point(160, 192);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(206, 26);
            this.Emailbox.TabIndex = 7;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Emaillabel.Location = new System.Drawing.Point(68, 195);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(48, 20);
            this.Emaillabel.TabIndex = 8;
            this.Emaillabel.Text = "Email";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.groupBox1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox Confirmbox;
        private System.Windows.Forms.Label ConfirmPasslabel;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Namelabel1;
    }
}