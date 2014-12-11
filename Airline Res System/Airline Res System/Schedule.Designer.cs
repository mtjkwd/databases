namespace Airline_Res_System
{
    partial class Schedule
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
            this.Schedule_Grid = new System.Windows.Forms.DataGridView();
            this.Schedule_Buy = new System.Windows.Forms.Button();
            this.Schedule_Close = new System.Windows.Forms.Button();
            this.Schedule_CheapestLbl = new System.Windows.Forms.Label();
            this.Schedule_BookingClassLbl = new System.Windows.Forms.Label();
            this.Schedule_NumPassLbl = new System.Windows.Forms.Label();
            this.Schedule_NumPass = new System.Windows.Forms.ComboBox();
            this.Schedule_Cheapest = new System.Windows.Forms.CheckBox();
            this.Schedule_PassEmailLbl = new System.Windows.Forms.Label();
            this.Status_PFname = new System.Windows.Forms.Label();
            this.Schedule_PLname = new System.Windows.Forms.Label();
            this.Schedule_PassEmail = new System.Windows.Forms.TextBox();
            this.Schedule_Fname = new System.Windows.Forms.TextBox();
            this.Schedule_Lname = new System.Windows.Forms.TextBox();
            this.Schedule_BookingClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Schedule_Grid
            // 
            this.Schedule_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_Grid.Location = new System.Drawing.Point(2, -1);
            this.Schedule_Grid.Name = "Schedule_Grid";
            this.Schedule_Grid.Size = new System.Drawing.Size(710, 451);
            this.Schedule_Grid.TabIndex = 0;
            this.Schedule_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schedule_Grid_CellClick);
            // 
            // Schedule_Buy
            // 
            this.Schedule_Buy.Enabled = false;
            this.Schedule_Buy.Location = new System.Drawing.Point(864, 380);
            this.Schedule_Buy.Name = "Schedule_Buy";
            this.Schedule_Buy.Size = new System.Drawing.Size(75, 23);
            this.Schedule_Buy.TabIndex = 1;
            this.Schedule_Buy.Text = "Buy Tickets";
            this.Schedule_Buy.UseVisualStyleBackColor = true;
            this.Schedule_Buy.Click += new System.EventHandler(this.Schedule_FareSelect_Click);
            // 
            // Schedule_Close
            // 
            this.Schedule_Close.Location = new System.Drawing.Point(754, 380);
            this.Schedule_Close.Name = "Schedule_Close";
            this.Schedule_Close.Size = new System.Drawing.Size(75, 23);
            this.Schedule_Close.TabIndex = 2;
            this.Schedule_Close.Text = "Close";
            this.Schedule_Close.UseVisualStyleBackColor = true;
            this.Schedule_Close.Click += new System.EventHandler(this.Schedule_Close_Click);
            // 
            // Schedule_CheapestLbl
            // 
            this.Schedule_CheapestLbl.AutoSize = true;
            this.Schedule_CheapestLbl.Location = new System.Drawing.Point(731, 68);
            this.Schedule_CheapestLbl.Name = "Schedule_CheapestLbl";
            this.Schedule_CheapestLbl.Size = new System.Drawing.Size(98, 13);
            this.Schedule_CheapestLbl.TabIndex = 3;
            this.Schedule_CheapestLbl.Text = "Cheapest (optional)";
            // 
            // Schedule_BookingClassLbl
            // 
            this.Schedule_BookingClassLbl.AutoSize = true;
            this.Schedule_BookingClassLbl.Location = new System.Drawing.Point(719, 112);
            this.Schedule_BookingClassLbl.Name = "Schedule_BookingClassLbl";
            this.Schedule_BookingClassLbl.Size = new System.Drawing.Size(122, 13);
            this.Schedule_BookingClassLbl.TabIndex = 4;
            this.Schedule_BookingClassLbl.Text = "Booking Class (Optional)";
            // 
            // Schedule_NumPassLbl
            // 
            this.Schedule_NumPassLbl.AutoSize = true;
            this.Schedule_NumPassLbl.Location = new System.Drawing.Point(731, 164);
            this.Schedule_NumPassLbl.Name = "Schedule_NumPassLbl";
            this.Schedule_NumPassLbl.Size = new System.Drawing.Size(84, 13);
            this.Schedule_NumPassLbl.TabIndex = 5;
            this.Schedule_NumPassLbl.Text = "# of Passengers";
            // 
            // Schedule_NumPass
            // 
            this.Schedule_NumPass.Enabled = false;
            this.Schedule_NumPass.FormattingEnabled = true;
            this.Schedule_NumPass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Schedule_NumPass.Location = new System.Drawing.Point(864, 161);
            this.Schedule_NumPass.Name = "Schedule_NumPass";
            this.Schedule_NumPass.Size = new System.Drawing.Size(100, 21);
            this.Schedule_NumPass.TabIndex = 8;
            // 
            // Schedule_Cheapest
            // 
            this.Schedule_Cheapest.AutoSize = true;
            this.Schedule_Cheapest.Enabled = false;
            this.Schedule_Cheapest.Location = new System.Drawing.Point(864, 68);
            this.Schedule_Cheapest.Name = "Schedule_Cheapest";
            this.Schedule_Cheapest.Size = new System.Drawing.Size(15, 14);
            this.Schedule_Cheapest.TabIndex = 9;
            this.Schedule_Cheapest.UseVisualStyleBackColor = true;
            // 
            // Schedule_PassEmailLbl
            // 
            this.Schedule_PassEmailLbl.AutoSize = true;
            this.Schedule_PassEmailLbl.Location = new System.Drawing.Point(730, 222);
            this.Schedule_PassEmailLbl.Name = "Schedule_PassEmailLbl";
            this.Schedule_PassEmailLbl.Size = new System.Drawing.Size(85, 13);
            this.Schedule_PassEmailLbl.TabIndex = 10;
            this.Schedule_PassEmailLbl.Text = "Passenger Email";
            // 
            // Status_PFname
            // 
            this.Status_PFname.AutoSize = true;
            this.Status_PFname.Location = new System.Drawing.Point(731, 261);
            this.Status_PFname.Name = "Status_PFname";
            this.Status_PFname.Size = new System.Drawing.Size(57, 13);
            this.Status_PFname.TabIndex = 11;
            this.Status_PFname.Text = "First Name";
            // 
            // Schedule_PLname
            // 
            this.Schedule_PLname.AutoSize = true;
            this.Schedule_PLname.Location = new System.Drawing.Point(731, 312);
            this.Schedule_PLname.Name = "Schedule_PLname";
            this.Schedule_PLname.Size = new System.Drawing.Size(58, 13);
            this.Schedule_PLname.TabIndex = 12;
            this.Schedule_PLname.Text = "Last Name";
            // 
            // Schedule_PassEmail
            // 
            this.Schedule_PassEmail.Enabled = false;
            this.Schedule_PassEmail.Location = new System.Drawing.Point(864, 215);
            this.Schedule_PassEmail.Name = "Schedule_PassEmail";
            this.Schedule_PassEmail.Size = new System.Drawing.Size(100, 20);
            this.Schedule_PassEmail.TabIndex = 13;
            // 
            // Schedule_Fname
            // 
            this.Schedule_Fname.Enabled = false;
            this.Schedule_Fname.Location = new System.Drawing.Point(864, 254);
            this.Schedule_Fname.Name = "Schedule_Fname";
            this.Schedule_Fname.Size = new System.Drawing.Size(100, 20);
            this.Schedule_Fname.TabIndex = 14;
            // 
            // Schedule_Lname
            // 
            this.Schedule_Lname.Enabled = false;
            this.Schedule_Lname.Location = new System.Drawing.Point(864, 305);
            this.Schedule_Lname.Name = "Schedule_Lname";
            this.Schedule_Lname.Size = new System.Drawing.Size(100, 20);
            this.Schedule_Lname.TabIndex = 15;
            // 
            // Schedule_BookingClass
            // 
            this.Schedule_BookingClass.Enabled = false;
            this.Schedule_BookingClass.FormattingEnabled = true;
            this.Schedule_BookingClass.Items.AddRange(new object[] {
            "F",
            "G",
            "H",
            "I",
            "K",
            "Y"});
            this.Schedule_BookingClass.Location = new System.Drawing.Point(864, 104);
            this.Schedule_BookingClass.Name = "Schedule_BookingClass";
            this.Schedule_BookingClass.Size = new System.Drawing.Size(100, 21);
            this.Schedule_BookingClass.TabIndex = 16;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.Schedule_BookingClass);
            this.Controls.Add(this.Schedule_Lname);
            this.Controls.Add(this.Schedule_Fname);
            this.Controls.Add(this.Schedule_PassEmail);
            this.Controls.Add(this.Schedule_PLname);
            this.Controls.Add(this.Status_PFname);
            this.Controls.Add(this.Schedule_PassEmailLbl);
            this.Controls.Add(this.Schedule_Cheapest);
            this.Controls.Add(this.Schedule_NumPass);
            this.Controls.Add(this.Schedule_NumPassLbl);
            this.Controls.Add(this.Schedule_BookingClassLbl);
            this.Controls.Add(this.Schedule_CheapestLbl);
            this.Controls.Add(this.Schedule_Close);
            this.Controls.Add(this.Schedule_Buy);
            this.Controls.Add(this.Schedule_Grid);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Schedule_Grid;
        private System.Windows.Forms.Button Schedule_Buy;
        private System.Windows.Forms.Button Schedule_Close;
        private System.Windows.Forms.Label Schedule_CheapestLbl;
        private System.Windows.Forms.Label Schedule_BookingClassLbl;
        private System.Windows.Forms.Label Schedule_NumPassLbl;
        private System.Windows.Forms.ComboBox Schedule_NumPass;
        private System.Windows.Forms.CheckBox Schedule_Cheapest;
        private System.Windows.Forms.Label Schedule_PassEmailLbl;
        private System.Windows.Forms.Label Status_PFname;
        private System.Windows.Forms.Label Schedule_PLname;
        private System.Windows.Forms.TextBox Schedule_PassEmail;
        private System.Windows.Forms.TextBox Schedule_Fname;
        private System.Windows.Forms.TextBox Schedule_Lname;
        private System.Windows.Forms.ComboBox Schedule_BookingClass;
    }
}