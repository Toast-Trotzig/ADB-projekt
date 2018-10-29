namespace ADB_projekt
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.BookTab = new System.Windows.Forms.TabPage();
            this.Phone_box = new System.Windows.Forms.TextBox();
            this.PhoneNr_lbl = new System.Windows.Forms.Label();
            this.CurrentBookings_lbl = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.BookDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.CarModelsView = new System.Windows.Forms.DataGridView();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.Class_Lbl = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Email_Lbl = new System.Windows.Forms.Label();
            this.Pnr_Box = new System.Windows.Forms.TextBox();
            this.Pnr_Lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Book_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Find_Btn = new System.Windows.Forms.Button();
            this.License_Box = new System.Windows.Forms.TextBox();
            this.License_Lbl = new System.Windows.Forms.Label();
            this.Pnr_Box2 = new System.Windows.Forms.TextBox();
            this.Pnr_lbl2 = new System.Windows.Forms.Label();
            this.Response_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.BookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarModelsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wioste™";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "That car rental place";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADB_projekt.Properties.Resources.w_logo_by_12who_d6hy5hi;
            this.pictureBox1.Location = new System.Drawing.Point(472, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.BookTab);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(784, 359);
            this.TabControl.TabIndex = 3;
            // 
            // BookTab
            // 
            this.BookTab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BookTab.Controls.Add(this.Response_lbl);
            this.BookTab.Controls.Add(this.Phone_box);
            this.BookTab.Controls.Add(this.PhoneNr_lbl);
            this.BookTab.Controls.Add(this.CurrentBookings_lbl);
            this.BookTab.Controls.Add(this.Date_lbl);
            this.BookTab.Controls.Add(this.BookDateCalendar);
            this.BookTab.Controls.Add(this.label3);
            this.BookTab.Controls.Add(this.CarModelsView);
            this.BookTab.Controls.Add(this.comboBox_class);
            this.BookTab.Controls.Add(this.Class_Lbl);
            this.BookTab.Controls.Add(this.Email_Box);
            this.BookTab.Controls.Add(this.Email_Lbl);
            this.BookTab.Controls.Add(this.Pnr_Box);
            this.BookTab.Controls.Add(this.Pnr_Lbl);
            this.BookTab.Controls.Add(this.dataGridView1);
            this.BookTab.Controls.Add(this.Name_Lbl);
            this.BookTab.Controls.Add(this.Name_Box);
            this.BookTab.Controls.Add(this.Book_btn);
            this.BookTab.Location = new System.Drawing.Point(4, 22);
            this.BookTab.Name = "BookTab";
            this.BookTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookTab.Size = new System.Drawing.Size(776, 333);
            this.BookTab.TabIndex = 0;
            this.BookTab.Text = "Booking";
            // 
            // Phone_box
            // 
            this.Phone_box.Location = new System.Drawing.Point(262, 32);
            this.Phone_box.Name = "Phone_box";
            this.Phone_box.Size = new System.Drawing.Size(100, 20);
            this.Phone_box.TabIndex = 19;
            // 
            // PhoneNr_lbl
            // 
            this.PhoneNr_lbl.AutoSize = true;
            this.PhoneNr_lbl.Location = new System.Drawing.Point(259, 15);
            this.PhoneNr_lbl.Name = "PhoneNr_lbl";
            this.PhoneNr_lbl.Size = new System.Drawing.Size(82, 13);
            this.PhoneNr_lbl.TabIndex = 18;
            this.PhoneNr_lbl.Text = "Phone Number*";
            // 
            // CurrentBookings_lbl
            // 
            this.CurrentBookings_lbl.AutoSize = true;
            this.CurrentBookings_lbl.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBookings_lbl.Location = new System.Drawing.Point(525, 3);
            this.CurrentBookings_lbl.Name = "CurrentBookings_lbl";
            this.CurrentBookings_lbl.Size = new System.Drawing.Size(170, 29);
            this.CurrentBookings_lbl.TabIndex = 17;
            this.CurrentBookings_lbl.Text = "Current bookings";
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Location = new System.Drawing.Point(148, 107);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(30, 13);
            this.Date_lbl.TabIndex = 16;
            this.Date_lbl.Text = "Date";
            // 
            // BookDateCalendar
            // 
            this.BookDateCalendar.Location = new System.Drawing.Point(151, 123);
            this.BookDateCalendar.Name = "BookDateCalendar";
            this.BookDateCalendar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Available cars";
            // 
            // CarModelsView
            // 
            this.CarModelsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarModelsView.Location = new System.Drawing.Point(6, 123);
            this.CarModelsView.Name = "CarModelsView";
            this.CarModelsView.Size = new System.Drawing.Size(133, 162);
            this.CarModelsView.TabIndex = 13;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(134, 77);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(100, 21);
            this.comboBox_class.TabIndex = 12;
            this.comboBox_class.SelectedIndexChanged += new System.EventHandler(this.comboBox_class_SelectedIndexChanged);
            // 
            // Class_Lbl
            // 
            this.Class_Lbl.AutoSize = true;
            this.Class_Lbl.Location = new System.Drawing.Point(132, 60);
            this.Class_Lbl.Name = "Class_Lbl";
            this.Class_Lbl.Size = new System.Drawing.Size(50, 13);
            this.Class_Lbl.TabIndex = 11;
            this.Class_Lbl.Text = "Car class";
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(6, 77);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(100, 20);
            this.Email_Box.TabIndex = 10;
            // 
            // Email_Lbl
            // 
            this.Email_Lbl.AutoSize = true;
            this.Email_Lbl.Location = new System.Drawing.Point(3, 60);
            this.Email_Lbl.Name = "Email_Lbl";
            this.Email_Lbl.Size = new System.Drawing.Size(36, 13);
            this.Email_Lbl.TabIndex = 9;
            this.Email_Lbl.Text = "Email*";
            // 
            // Pnr_Box
            // 
            this.Pnr_Box.Location = new System.Drawing.Point(134, 32);
            this.Pnr_Box.Name = "Pnr_Box";
            this.Pnr_Box.Size = new System.Drawing.Size(100, 20);
            this.Pnr_Box.TabIndex = 8;
            // 
            // Pnr_Lbl
            // 
            this.Pnr_Lbl.AutoSize = true;
            this.Pnr_Lbl.Location = new System.Drawing.Point(131, 16);
            this.Pnr_Lbl.Name = "Pnr_Lbl";
            this.Pnr_Lbl.Size = new System.Drawing.Size(90, 13);
            this.Pnr_Lbl.TabIndex = 7;
            this.Pnr_Lbl.Text = "Personal number*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 278);
            this.dataGridView1.TabIndex = 6;
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(3, 16);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(39, 13);
            this.Name_Lbl.TabIndex = 5;
            this.Name_Lbl.Text = "Name*";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(6, 32);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(100, 20);
            this.Name_Box.TabIndex = 4;
            // 
            // Book_btn
            // 
            this.Book_btn.Location = new System.Drawing.Point(6, 291);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(75, 24);
            this.Book_btn.TabIndex = 3;
            this.Book_btn.Text = " Book";
            this.Book_btn.UseVisualStyleBackColor = true;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.Find_Btn);
            this.tabPage2.Controls.Add(this.License_Box);
            this.tabPage2.Controls.Add(this.License_Lbl);
            this.tabPage2.Controls.Add(this.Pnr_Box2);
            this.tabPage2.Controls.Add(this.Pnr_lbl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage bookings";
            // 
            // Find_Btn
            // 
            this.Find_Btn.Location = new System.Drawing.Point(7, 116);
            this.Find_Btn.Name = "Find_Btn";
            this.Find_Btn.Size = new System.Drawing.Size(100, 23);
            this.Find_Btn.TabIndex = 8;
            this.Find_Btn.Text = "Find booking";
            this.Find_Btn.UseVisualStyleBackColor = true;
            // 
            // License_Box
            // 
            this.License_Box.Location = new System.Drawing.Point(7, 78);
            this.License_Box.Name = "License_Box";
            this.License_Box.Size = new System.Drawing.Size(100, 20);
            this.License_Box.TabIndex = 7;
            // 
            // License_Lbl
            // 
            this.License_Lbl.AutoSize = true;
            this.License_Lbl.Location = new System.Drawing.Point(7, 61);
            this.License_Lbl.Name = "License_Lbl";
            this.License_Lbl.Size = new System.Drawing.Size(82, 13);
            this.License_Lbl.TabIndex = 6;
            this.License_Lbl.Text = "License number";
            // 
            // Pnr_Box2
            // 
            this.Pnr_Box2.Location = new System.Drawing.Point(7, 34);
            this.Pnr_Box2.Name = "Pnr_Box2";
            this.Pnr_Box2.Size = new System.Drawing.Size(100, 20);
            this.Pnr_Box2.TabIndex = 5;
            // 
            // Pnr_lbl2
            // 
            this.Pnr_lbl2.AutoSize = true;
            this.Pnr_lbl2.Location = new System.Drawing.Point(7, 17);
            this.Pnr_lbl2.Name = "Pnr_lbl2";
            this.Pnr_lbl2.Size = new System.Drawing.Size(86, 13);
            this.Pnr_lbl2.TabIndex = 4;
            this.Pnr_lbl2.Text = "Personal number";
            // 
            // Response_lbl
            // 
            this.Response_lbl.AutoSize = true;
            this.Response_lbl.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Response_lbl.ForeColor = System.Drawing.Color.Red;
            this.Response_lbl.Location = new System.Drawing.Point(87, 297);
            this.Response_lbl.Name = "Response_lbl";
            this.Response_lbl.Size = new System.Drawing.Size(0, 23);
            this.Response_lbl.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.BookTab.ResumeLayout(false);
            this.BookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarModelsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage BookTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Pnr_Box;
        private System.Windows.Forms.Label Pnr_Lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Class_Lbl;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label Email_Lbl;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.TextBox Pnr_Box2;
        private System.Windows.Forms.Label Pnr_lbl2;
        private System.Windows.Forms.Label License_Lbl;
        private System.Windows.Forms.Button Find_Btn;
        private System.Windows.Forms.TextBox License_Box;
        private System.Windows.Forms.DataGridView CarModelsView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar BookDateCalendar;
        private System.Windows.Forms.Label CurrentBookings_lbl;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.TextBox Phone_box;
        private System.Windows.Forms.Label PhoneNr_lbl;
        private System.Windows.Forms.Label Response_lbl;
    }
}

