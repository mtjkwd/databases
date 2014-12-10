using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Airline_Res_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MYSQLConn connection = new MYSQLConn();
            // Initialize field values //
            // Setup detailed values for airport source /destination //
            List<Airport> airports = connection.getAirports();
            foreach (Airport airport in airports)
            {
                Main_DepAirport.Items.Add(airport.name.ToString());
                Main_ArrAirport.Items.Add(airport.name.ToString());
            }
            // Set Main_DateTime field to current date //
            Main_DateTime.Value = System.DateTime.Now; // uses local time zone for user //
            Main_DateTime.MinDate = System.DateTime.Now; // only future reservations accepted //
        }

        private void Main_ScheduleBtn_Click(object sender, EventArgs e)
        {
            // Open schedule form //
            Form Schedule = new Schedule();
            Schedule.Show();
        }

        private void Main_BuyBtn_Click(object sender, EventArgs e)
        {
            // Run main screen validation, then calc ticket quote and show to user //
            // Only unlocked when the user clicks the Quote button for a fare //
            Form Buy = new BuyTicket();
            Buy.Show();
        }

        private void Main_StatusBtn_Click(object sender, EventArgs e)
        {
            // Run main screen validation, then show status of flight if found, error if not //
            Form Status = new Status();
            Control statusGridControl = Status.Controls.Find("Status_Grid");
            DataGridView statusGrid = (DataGridView)statusGridControl;

            // Create data table to populate the grid, from sql data returned //


            Status.Show();
        }

        private void Main_QuoteBtn_Click(object sender, EventArgs e)
        {
            // Run main screen validation, then calc ticket quote and show to user //
            // After quote is shown, unlock the buy button //
            Form Quote = new Quote();
            Quote.Show();
        }      
    }
}
