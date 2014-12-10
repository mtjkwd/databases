namespace Airline_Res_System
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
            this.Main_DepAirportLbl = new System.Windows.Forms.Label();
            this.Main_ArrAirportLbl = new System.Windows.Forms.Label();
            this.Main_DepAirport = new System.Windows.Forms.ComboBox();
            this.Main_ArrAirport = new System.Windows.Forms.ComboBox();
            this.Main_ProgFuncLbl = new System.Windows.Forms.Label();
            this.Main_DateTimeLbl = new System.Windows.Forms.Label();
            this.Main_DateTime = new System.Windows.Forms.DateTimePicker();
            this.Main_CheapBtnLbl = new System.Windows.Forms.Label();
            this.Main_CheapBtn = new System.Windows.Forms.CheckBox();
            this.Main_BookingClLabel = new System.Windows.Forms.Label();
            this.Main_BookingCl = new System.Windows.Forms.TextBox();
            this.Main_PassengersLbl = new System.Windows.Forms.Label();
            this.Main_BuyBtn = new System.Windows.Forms.Button();
            this.Main_ScheduleBtn = new System.Windows.Forms.Button();
            this.Main_StatusBtn = new System.Windows.Forms.Button();
            this.Main_QuoteBtn = new System.Windows.Forms.Button();
            this.Main_Passengers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Main_DepAirportLbl
            // 
            this.Main_DepAirportLbl.AutoSize = true;
            this.Main_DepAirportLbl.Location = new System.Drawing.Point(28, 27);
            this.Main_DepAirportLbl.Name = "Main_DepAirportLbl";
            this.Main_DepAirportLbl.Size = new System.Drawing.Size(87, 13);
            this.Main_DepAirportLbl.TabIndex = 0;
            this.Main_DepAirportLbl.Text = "Departure Airport";
            // 
            // Main_ArrAirportLbl
            // 
            this.Main_ArrAirportLbl.AutoSize = true;
            this.Main_ArrAirportLbl.Location = new System.Drawing.Point(28, 58);
            this.Main_ArrAirportLbl.Name = "Main_ArrAirportLbl";
            this.Main_ArrAirportLbl.Size = new System.Drawing.Size(69, 13);
            this.Main_ArrAirportLbl.TabIndex = 1;
            this.Main_ArrAirportLbl.Text = "Arrival Airport";
            // 
            // Main_DepAirport
            // 
            this.Main_DepAirport.FormattingEnabled = true;
            this.Main_DepAirport.Location = new System.Drawing.Point(150, 27);
            this.Main_DepAirport.Name = "Main_DepAirport";
            this.Main_DepAirport.Size = new System.Drawing.Size(121, 21);
            this.Main_DepAirport.TabIndex = 2;
            // 
            // Main_ArrAirport
            // 
            this.Main_ArrAirport.FormattingEnabled = true;
            this.Main_ArrAirport.Location = new System.Drawing.Point(150, 58);
            this.Main_ArrAirport.Name = "Main_ArrAirport";
            this.Main_ArrAirport.Size = new System.Drawing.Size(121, 21);
            this.Main_ArrAirport.TabIndex = 3;
            // 
            // Main_ProgFuncLbl
            // 
            this.Main_ProgFuncLbl.AutoSize = true;
            this.Main_ProgFuncLbl.Location = new System.Drawing.Point(28, 129);
            this.Main_ProgFuncLbl.Name = "Main_ProgFuncLbl";
            this.Main_ProgFuncLbl.Size = new System.Drawing.Size(51, 13);
            this.Main_ProgFuncLbl.TabIndex = 4;
            this.Main_ProgFuncLbl.Text = "Pick One";
            // 
            // Main_DateTimeLbl
            // 
            this.Main_DateTimeLbl.AutoSize = true;
            this.Main_DateTimeLbl.Location = new System.Drawing.Point(322, 27);
            this.Main_DateTimeLbl.Name = "Main_DateTimeLbl";
            this.Main_DateTimeLbl.Size = new System.Drawing.Size(80, 13);
            this.Main_DateTimeLbl.TabIndex = 5;
            this.Main_DateTimeLbl.Text = "Departure Time";
            // 
            // Main_DateTime
            // 
            this.Main_DateTime.Location = new System.Drawing.Point(424, 27);
            this.Main_DateTime.Name = "Main_DateTime";
            this.Main_DateTime.Size = new System.Drawing.Size(200, 20);
            this.Main_DateTime.TabIndex = 6;
            // 
            // Main_CheapBtnLbl
            // 
            this.Main_CheapBtnLbl.AutoSize = true;
            this.Main_CheapBtnLbl.Location = new System.Drawing.Point(367, 58);
            this.Main_CheapBtnLbl.Name = "Main_CheapBtnLbl";
            this.Main_CheapBtnLbl.Size = new System.Drawing.Size(101, 13);
            this.Main_CheapBtnLbl.TabIndex = 7;
            this.Main_CheapBtnLbl.Text = "Cheapest (optional):";
            // 
            // Main_CheapBtn
            // 
            this.Main_CheapBtn.AutoSize = true;
            this.Main_CheapBtn.Location = new System.Drawing.Point(472, 53);
            this.Main_CheapBtn.Name = "Main_CheapBtn";
            this.Main_CheapBtn.Size = new System.Drawing.Size(15, 14);
            this.Main_CheapBtn.TabIndex = 8;
            this.Main_CheapBtn.UseVisualStyleBackColor = true;
            // 
            // Main_BookingClLabel
            // 
            this.Main_BookingClLabel.AutoSize = true;
            this.Main_BookingClLabel.Location = new System.Drawing.Point(367, 83);
            this.Main_BookingClLabel.Name = "Main_BookingClLabel";
            this.Main_BookingClLabel.Size = new System.Drawing.Size(120, 13);
            this.Main_BookingClLabel.TabIndex = 9;
            this.Main_BookingClLabel.Text = "Booking Class (optional)";
            // 
            // Main_BookingCl
            // 
            this.Main_BookingCl.Location = new System.Drawing.Point(519, 76);
            this.Main_BookingCl.Name = "Main_BookingCl";
            this.Main_BookingCl.Size = new System.Drawing.Size(28, 20);
            this.Main_BookingCl.TabIndex = 10;
            // 
            // Main_PassengersLbl
            // 
            this.Main_PassengersLbl.AutoSize = true;
            this.Main_PassengersLbl.Location = new System.Drawing.Point(367, 112);
            this.Main_PassengersLbl.Name = "Main_PassengersLbl";
            this.Main_PassengersLbl.Size = new System.Drawing.Size(84, 13);
            this.Main_PassengersLbl.TabIndex = 12;
            this.Main_PassengersLbl.Text = "# of Passengers";
            // 
            // Main_BuyBtn
            // 
            this.Main_BuyBtn.Enabled = false;
            this.Main_BuyBtn.Location = new System.Drawing.Point(94, 102);
            this.Main_BuyBtn.Name = "Main_BuyBtn";
            this.Main_BuyBtn.Size = new System.Drawing.Size(90, 23);
            this.Main_BuyBtn.TabIndex = 13;
            this.Main_BuyBtn.Text = "Buy Ticket";
            this.Main_BuyBtn.UseVisualStyleBackColor = true;
            this.Main_BuyBtn.Click += new System.EventHandler(this.Main_BuyBtn_Click);
            // 
            // Main_ScheduleBtn
            // 
            this.Main_ScheduleBtn.Location = new System.Drawing.Point(209, 102);
            this.Main_ScheduleBtn.Name = "Main_ScheduleBtn";
            this.Main_ScheduleBtn.Size = new System.Drawing.Size(101, 23);
            this.Main_ScheduleBtn.TabIndex = 14;
            this.Main_ScheduleBtn.Text = "Show Schedule";
            this.Main_ScheduleBtn.UseVisualStyleBackColor = true;
            this.Main_ScheduleBtn.Click += new System.EventHandler(this.Main_ScheduleBtn_Click);
            // 
            // Main_StatusBtn
            // 
            this.Main_StatusBtn.Location = new System.Drawing.Point(94, 142);
            this.Main_StatusBtn.Name = "Main_StatusBtn";
            this.Main_StatusBtn.Size = new System.Drawing.Size(75, 23);
            this.Main_StatusBtn.TabIndex = 15;
            this.Main_StatusBtn.Text = "Flight Status";
            this.Main_StatusBtn.UseVisualStyleBackColor = true;
            this.Main_StatusBtn.Click += new System.EventHandler(this.Main_StatusBtn_Click);
            // 
            // Main_QuoteBtn
            // 
            this.Main_QuoteBtn.Location = new System.Drawing.Point(209, 142);
            this.Main_QuoteBtn.Name = "Main_QuoteBtn";
            this.Main_QuoteBtn.Size = new System.Drawing.Size(75, 23);
            this.Main_QuoteBtn.TabIndex = 16;
            this.Main_QuoteBtn.Text = "Get Quote";
            this.Main_QuoteBtn.UseVisualStyleBackColor = true;
            this.Main_QuoteBtn.Click += new System.EventHandler(this.Main_QuoteBtn_Click);
            // 
            // Main_Passengers
            // 
            this.Main_Passengers.FormattingEnabled = true;
            this.Main_Passengers.Items.AddRange(new object[] {
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
            this.Main_Passengers.Location = new System.Drawing.Point(499, 112);
            this.Main_Passengers.Name = "Main_Passengers";
            this.Main_Passengers.Size = new System.Drawing.Size(48, 21);
            this.Main_Passengers.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 178);
            this.Controls.Add(this.Main_Passengers);
            this.Controls.Add(this.Main_QuoteBtn);
            this.Controls.Add(this.Main_StatusBtn);
            this.Controls.Add(this.Main_ScheduleBtn);
            this.Controls.Add(this.Main_BuyBtn);
            this.Controls.Add(this.Main_PassengersLbl);
            this.Controls.Add(this.Main_BookingCl);
            this.Controls.Add(this.Main_BookingClLabel);
            this.Controls.Add(this.Main_CheapBtn);
            this.Controls.Add(this.Main_CheapBtnLbl);
            this.Controls.Add(this.Main_DateTime);
            this.Controls.Add(this.Main_DateTimeLbl);
            this.Controls.Add(this.Main_ProgFuncLbl);
            this.Controls.Add(this.Main_ArrAirport);
            this.Controls.Add(this.Main_DepAirport);
            this.Controls.Add(this.Main_ArrAirportLbl);
            this.Controls.Add(this.Main_DepAirportLbl);
            this.Name = "Form1";
            this.Text = "Airline Reservation System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_DepAirportLbl;
        private System.Windows.Forms.Label Main_ArrAirportLbl;
        private System.Windows.Forms.ComboBox Main_DepAirport;
        private System.Windows.Forms.ComboBox Main_ArrAirport;
        private System.Windows.Forms.Label Main_ProgFuncLbl;
        private System.Windows.Forms.Label Main_DateTimeLbl;
        private System.Windows.Forms.DateTimePicker Main_DateTime;
        private System.Windows.Forms.Label Main_CheapBtnLbl;
        private System.Windows.Forms.CheckBox Main_CheapBtn;
        private System.Windows.Forms.Label Main_BookingClLabel;
        private System.Windows.Forms.TextBox Main_BookingCl;
        private System.Windows.Forms.Label Main_PassengersLbl;
        private System.Windows.Forms.Button Main_BuyBtn;
        private System.Windows.Forms.Button Main_ScheduleBtn;
        private System.Windows.Forms.Button Main_StatusBtn;
        private System.Windows.Forms.Button Main_QuoteBtn;
        private System.Windows.Forms.ComboBox Main_Passengers;
    }
}

