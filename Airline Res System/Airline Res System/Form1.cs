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
            Control[] Schedule_GridControl = Schedule.Controls.Find("Schedule_Grid", true);
            DataGridView Schedule_Grid = (DataGridView)Schedule_GridControl[0];
            Schedule_Grid.ReadOnly = true;

            // Call a validation function here to check FROM 1 input //

            // Create a data table to populate returned sql data //
            DataTable scheduleTable = new DataTable();
            scheduleTable.Columns.Add("Airline");
            scheduleTable.Columns.Add("Flight Number");
            scheduleTable.Columns.Add("Departure Airport");
            scheduleTable.Columns.Add("Departure Time");
            scheduleTable.Columns.Add("Arrival Airport");
            scheduleTable.Columns.Add("Arrival Time");
            scheduleTable.Columns.Add("Total Seats");

            List<Flight> flights;
            // Get the data from SQL //
            MYSQLConn connection = new MYSQLConn();
            if (this.Main_DepAirport.Text.ToString() != String.Empty && this.Main_ArrAirport.Text.ToString() != String.Empty)
            {
                //flights = connection.getFlights(this.Main_DateTime.Value.ToString("yyyy-MM-dd"));
                flights = connection.getFlightsBothAirports(this.Main_DateTime.Value.ToString("yyyy-MM-dd"), this.Main_DepAirport.Text.ToString(), this.Main_ArrAirport.Text.ToString());
            }
            else if (this.Main_DepAirport.Text.ToString() != String.Empty)
            {
                // Get arrival airport info //
                flights = connection.getFlightsDepAirport(this.Main_DateTime.Value.ToString("yyyy-MM-dd"), this.Main_ArrAirport.Text.ToString());
            }
            else if (this.Main_ArrAirport.Text.ToString() != String.Empty)
            {
                // Only get departure airport flights on the spec. date
                flights = connection.getFlightsDepAirport(this.Main_DateTime.Value.ToString("yyyy-MM-dd"), this.Main_DepAirport.Text.ToString());
            }
            else
            {
                // Gets flights at both airports
                flights = connection.getFlights(this.Main_DateTime.Value.ToString("yyyy-MM-dd"));
            }
            
            
            if (flights.Count == 0)
            {
                MessageBox.Show("No Flights Found");
                return;
            }
            foreach (Flight flight in flights)
            {
                // Add the data into the DataTable //
                DataRow temp = scheduleTable.Rows.Add();
                temp[0] = flight.airline.ToString();
                temp[1] = flight.flightNum.ToString();
                temp[2] = flight.depAirport.ToString();
                temp[3] = flight.depTime.ToString();
                temp[4] = flight.arrAirport.ToString();
                temp[5] = flight.arrTime.ToString();
                temp[6] = flight.maxSeats.ToString();
                temp.AcceptChanges();
            }

            Schedule_Grid.DataSource = scheduleTable;

            // Show values from From1 control //
            Control[] CheapestControl = Schedule.Controls.Find("Schedule_Cheapest", true);
            Control[] ClassControl = Schedule.Controls.Find("Schedule_BookingClass", true);
            Control[] PassengersControl = Schedule.Controls.Find("Schedule_NumPass", true);
            
            // Load controls, put values into them from parent form //
            CheckBox Cheapest = (CheckBox)CheapestControl[0];
            TextBox Class = (TextBox)ClassControl[0];
            ComboBox Passengers = (ComboBox)PassengersControl[0];

            Cheapest.Checked = this.Main_CheapBtn.Checked;
            Class.Text = this.Main_BookingCl.Text;
            Passengers.SelectedIndex = this.Main_Passengers.SelectedIndex;

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
            Control[] statusGridControl = Status.Controls.Find("Status_Grid", true);
            DataGridView statusGrid = (DataGridView)statusGridControl[0];

            // Call a validation function here to check FORM 1 input //

            // Create data table to populate the grid, from sql data returned //
            DataTable statusTable = new DataTable();
            statusTable.Columns.Add("Airline");
            statusTable.Columns.Add("Flight Number");
            statusTable.Columns.Add("Flight Status");
            statusTable.Columns.Add("Departure Airport");
            statusTable.Columns.Add("Departure Time");
            statusTable.Columns.Add("Arrival Airport");
            statusTable.Columns.Add("Arrival Time");




            statusTable.AcceptChanges();
            statusGrid.DataSource = statusTable;
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
