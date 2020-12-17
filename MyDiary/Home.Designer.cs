
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dltbutton1 = new System.Windows.Forms.Button();
            this.DlttextBox2 = new System.Windows.Forms.TextBox();
            this.ModifyDiary = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Searchlabel1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(675, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(391, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UpdaterichTextBox1
            // 
            this.UpdaterichTextBox1.Location = new System.Drawing.Point(365, 325);
            this.UpdaterichTextBox1.Name = "UpdaterichTextBox1";
            this.UpdaterichTextBox1.Size = new System.Drawing.Size(697, 218);
            this.UpdaterichTextBox1.TabIndex = 2;
            this.UpdaterichTextBox1.Text = "";
            this.UpdaterichTextBox1.TextChanged += new System.EventHandler(this.UpdaterichTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dltbutton1);
            this.groupBox1.Controls.Add(this.DlttextBox2);
            this.groupBox1.Location = new System.Drawing.Point(35, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diary Delete Panel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Id";
            // 
            // Dltbutton1
            // 
            this.Dltbutton1.Location = new System.Drawing.Point(129, 86);
            this.Dltbutton1.Name = "Dltbutton1";
            this.Dltbutton1.Size = new System.Drawing.Size(75, 23);
            this.Dltbutton1.TabIndex = 6;
            this.Dltbutton1.Text = "Delete";
            this.Dltbutton1.UseVisualStyleBackColor = true;
            this.Dltbutton1.Click += new System.EventHandler(this.Dltbutton1_Click);
            // 
            // DlttextBox2
            // 
            this.DlttextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DlttextBox2.Location = new System.Drawing.Point(98, 42);
            this.DlttextBox2.Name = "DlttextBox2";
            this.DlttextBox2.Size = new System.Drawing.Size(138, 26);
            this.DlttextBox2.TabIndex = 5;
            this.DlttextBox2.TextChanged += new System.EventHandler(this.DlttextBox2_TextChanged);
            // 
            // ModifyDiary
            // 
            this.ModifyDiary.Location = new System.Drawing.Point(129, 81);
            this.ModifyDiary.Name = "ModifyDiary";
            this.ModifyDiary.Size = new System.Drawing.Size(75, 23);
            this.ModifyDiary.TabIndex = 4;
            this.ModifyDiary.Text = "Modify";
            this.ModifyDiary.UseVisualStyleBackColor = true;
            this.ModifyDiary.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(365, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(365, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(304, 230);
            this.dataGridView2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.ModifyDiary);
            this.groupBox2.Location = new System.Drawing.Point(35, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Modify Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modify Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(98, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 26);
            this.textBox2.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Searchlabel1);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diarybutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox UpdaterichTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Searchlabel1;
        private System.Windows.Forms.Button ModifyDiary;
        private System.Windows.Forms.Button Dltbutton1;
        private System.Windows.Forms.TextBox DlttextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}