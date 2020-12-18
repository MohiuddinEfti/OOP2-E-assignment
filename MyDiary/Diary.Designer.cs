
namespace MyDiary
{
    partial class Diary
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
            this.NewEventlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportancecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Uploadbutton1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datelabel1 = new System.Windows.Forms.Label();
            this.Eventbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiaryrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Homebutton1 = new System.Windows.Forms.Button();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.Logoutbutton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.NewEventlabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ImportancecomboBox1);
            this.groupBox1.Controls.Add(this.Uploadbutton1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Datelabel1);
            this.groupBox1.Controls.Add(this.Eventbox);
            this.groupBox1.Location = new System.Drawing.Point(86, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event";
            // 
            // NewEventlabel
            // 
            this.NewEventlabel.AutoSize = true;
            this.NewEventlabel.Location = new System.Drawing.Point(21, 67);
            this.NewEventlabel.Name = "NewEventlabel";
            this.NewEventlabel.Size = new System.Drawing.Size(35, 13);
            this.NewEventlabel.TabIndex = 9;
            this.NewEventlabel.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Importance";
            // 
            // ImportancecomboBox1
            // 
            this.ImportancecomboBox1.BackColor = System.Drawing.Color.White;
            this.ImportancecomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ImportancecomboBox1.FormattingEnabled = true;
            this.ImportancecomboBox1.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.ImportancecomboBox1.Location = new System.Drawing.Point(72, 100);
            this.ImportancecomboBox1.Name = "ImportancecomboBox1";
            this.ImportancecomboBox1.Size = new System.Drawing.Size(138, 28);
            this.ImportancecomboBox1.TabIndex = 6;
            this.ImportancecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Uploadbutton1
            // 
            this.Uploadbutton1.Location = new System.Drawing.Point(59, 220);
            this.Uploadbutton1.Name = "Uploadbutton1";
            this.Uploadbutton1.Size = new System.Drawing.Size(111, 23);
            this.Uploadbutton1.TabIndex = 5;
            this.Uploadbutton1.Text = "Upload Picture";
            this.Uploadbutton1.UseVisualStyleBackColor = true;
            this.Uploadbutton1.Click += new System.EventHandler(this.Uploadbutton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 138);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Datelabel1
            // 
            this.Datelabel1.AutoSize = true;
            this.Datelabel1.Location = new System.Drawing.Point(27, 143);
            this.Datelabel1.Name = "Datelabel1";
            this.Datelabel1.Size = new System.Drawing.Size(30, 13);
            this.Datelabel1.TabIndex = 3;
            this.Datelabel1.Text = "Date";
            // 
            // Eventbox
            // 
            this.Eventbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventbox.Location = new System.Drawing.Point(72, 60);
            this.Eventbox.Name = "Eventbox";
            this.Eventbox.Size = new System.Drawing.Size(138, 26);
            this.Eventbox.TabIndex = 1;
            this.Eventbox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(93, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DiaryrichTextBox1
            // 
            this.DiaryrichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiaryrichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaryrichTextBox1.Location = new System.Drawing.Point(371, 57);
            this.DiaryrichTextBox1.Name = "DiaryrichTextBox1";
            this.DiaryrichTextBox1.Size = new System.Drawing.Size(681, 457);
            this.DiaryrichTextBox1.TabIndex = 2;
            this.DiaryrichTextBox1.Text = "";
            // 
            // Homebutton1
            // 
            this.Homebutton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Homebutton1.Location = new System.Drawing.Point(749, 556);
            this.Homebutton1.Name = "Homebutton1";
            this.Homebutton1.Size = new System.Drawing.Size(138, 23);
            this.Homebutton1.TabIndex = 3;
            this.Homebutton1.Text = "Home";
            this.Homebutton1.UseVisualStyleBackColor = true;
            this.Homebutton1.Click += new System.EventHandler(this.Homebutton1_Click);
            // 
            // Savebutton1
            // 
            this.Savebutton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebutton1.Location = new System.Drawing.Point(587, 556);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(138, 23);
            this.Savebutton1.TabIndex = 4;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // Logoutbutton1
            // 
            this.Logoutbutton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logoutbutton1.Location = new System.Drawing.Point(1024, 12);
            this.Logoutbutton1.Name = "Logoutbutton1";
            this.Logoutbutton1.Size = new System.Drawing.Size(75, 23);
            this.Logoutbutton1.TabIndex = 5;
            this.Logoutbutton1.Text = "Log out";
            this.Logoutbutton1.UseVisualStyleBackColor = true;
            this.Logoutbutton1.Click += new System.EventHandler(this.Logoutbutton1_Click);
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.Logoutbutton1);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.Homebutton1);
            this.Controls.Add(this.DiaryrichTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Diary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diary_FormClosing);
            this.Load += new System.EventHandler(this.Diary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Eventbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datelabel1;
        private System.Windows.Forms.Button Uploadbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox DiaryrichTextBox1;
        private System.Windows.Forms.Button Homebutton1;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button Logoutbutton1;
        private System.Windows.Forms.ComboBox ImportancecomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewEventlabel;
    }
}