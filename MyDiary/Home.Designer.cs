
namespace MyDiary
{
    partial class Home
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
            this.Diarybutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdaterichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateDiary = new System.Windows.Forms.Button();
            this.Eventlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Searchlabel1 = new System.Windows.Forms.Label();
            this.DlttextBox2 = new System.Windows.Forms.TextBox();
            this.Dltbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diarybutton1
            // 
            this.Diarybutton1.Location = new System.Drawing.Point(987, 27);
            this.Diarybutton1.Name = "Diarybutton1";
            this.Diarybutton1.Size = new System.Drawing.Size(75, 23);
            this.Diarybutton1.TabIndex = 0;
            this.Diarybutton1.Text = "Diary";
            this.Diarybutton1.UseVisualStyleBackColor = true;
            this.Diarybutton1.Click += new System.EventHandler(this.Diarybutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(701, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UpdaterichTextBox1
            // 
            this.UpdaterichTextBox1.Location = new System.Drawing.Point(365, 325);
            this.UpdaterichTextBox1.Name = "UpdaterichTextBox1";
            this.UpdaterichTextBox1.Size = new System.Drawing.Size(491, 218);
            this.UpdaterichTextBox1.TabIndex = 2;
            this.UpdaterichTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(862, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dltbutton1);
            this.groupBox1.Controls.Add(this.DlttextBox2);
            this.groupBox1.Controls.Add(this.Eventlabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 564);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Panel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // UpdateDiary
            // 
            this.UpdateDiary.Location = new System.Drawing.Point(578, 558);
            this.UpdateDiary.Name = "UpdateDiary";
            this.UpdateDiary.Size = new System.Drawing.Size(75, 23);
            this.UpdateDiary.TabIndex = 4;
            this.UpdateDiary.Text = "Update";
            this.UpdateDiary.UseVisualStyleBackColor = true;
            this.UpdateDiary.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eventlabel
            // 
            this.Eventlabel.AutoSize = true;
            this.Eventlabel.Location = new System.Drawing.Point(55, 67);
            this.Eventlabel.Name = "Eventlabel";
            this.Eventlabel.Size = new System.Drawing.Size(40, 13);
            this.Eventlabel.TabIndex = 3;
            this.Eventlabel.Text = "Events";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(365, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Searchlabel1
            // 
            this.Searchlabel1.AutoSize = true;
            this.Searchlabel1.Location = new System.Drawing.Point(575, 35);
            this.Searchlabel1.Name = "Searchlabel1";
            this.Searchlabel1.Size = new System.Drawing.Size(41, 13);
            this.Searchlabel1.TabIndex = 4;
            this.Searchlabel1.Text = "Search";
            // 
            // DlttextBox2
            // 
            this.DlttextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DlttextBox2.Location = new System.Drawing.Point(92, 308);
            this.DlttextBox2.Name = "DlttextBox2";
            this.DlttextBox2.Size = new System.Drawing.Size(138, 26);
            this.DlttextBox2.TabIndex = 5;
            // 
            // Dltbutton1
            // 
            this.Dltbutton1.Location = new System.Drawing.Point(119, 359);
            this.Dltbutton1.Name = "Dltbutton1";
            this.Dltbutton1.Size = new System.Drawing.Size(75, 23);
            this.Dltbutton1.TabIndex = 6;
            this.Dltbutton1.Text = "Delete";
            this.Dltbutton1.UseVisualStyleBackColor = true;
            this.Dltbutton1.Click += new System.EventHandler(this.Dltbutton1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.Searchlabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UpdateDiary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdaterichTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Diarybutton1);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diarybutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox UpdaterichTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Eventlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Searchlabel1;
        private System.Windows.Forms.Button UpdateDiary;
        private System.Windows.Forms.Button Dltbutton1;
        private System.Windows.Forms.TextBox DlttextBox2;
    }
}