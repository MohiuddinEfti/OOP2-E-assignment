
namespace MyDiary
{
    partial class Login
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
            this.Namebox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Signinbutton = new System.Windows.Forms.Button();
            this.Namelabel1 = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(119, 110);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(206, 26);
            this.Namebox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(119, 160);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(206, 26);
            this.PasswordBox.TabIndex = 1;
            // 
            // Signinbutton
            // 
            this.Signinbutton.Location = new System.Drawing.Point(136, 216);
            this.Signinbutton.Name = "Signinbutton";
            this.Signinbutton.Size = new System.Drawing.Size(75, 23);
            this.Signinbutton.TabIndex = 2;
            this.Signinbutton.Text = "Login";
            this.Signinbutton.UseVisualStyleBackColor = true;
            this.Signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // Namelabel1
            // 
            this.Namelabel1.AutoSize = true;
            this.Namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Namelabel1.Location = new System.Drawing.Point(24, 116);
            this.Namelabel1.Name = "Namelabel1";
            this.Namelabel1.Size = new System.Drawing.Size(89, 20);
            this.Namelabel1.TabIndex = 3;
            this.Namelabel1.Text = "User Name";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Passwordlabel.Location = new System.Drawing.Point(30, 163);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(78, 20);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password";
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.Transparent;
            this.Signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Signup.Location = new System.Drawing.Point(232, 216);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(75, 23);
            this.Signup.TabIndex = 5;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "or";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Namebox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.Signup);
            this.groupBox1.Controls.Add(this.Signinbutton);
            this.groupBox1.Controls.Add(this.Passwordlabel);
            this.groupBox1.Controls.Add(this.Namelabel1);
            this.groupBox1.Location = new System.Drawing.Point(334, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 348);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Diary";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Signinbutton;
        private System.Windows.Forms.Label Namelabel1;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

