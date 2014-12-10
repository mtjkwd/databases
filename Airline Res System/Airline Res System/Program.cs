using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Airline_Res_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        class Airport
        {
            public string name;
            public string state;
            public string city;
            public string iata;
            public int runwayCount;
            public Airport(string name, string state, string city, string iata, int runwayCount){
                this.name = name;
                this.state = state;
                this.city = city;
                this.iata = iata;
                this.runwayCount = runwayCount;
            }
        }

        class Fare
        {
            public string Class;
            public int flightNum;
            public int maxSeats;
            public int price;
            public Fare(string Class, int flightNum, int maxSeats, int price){
                this.Class = Class;
                this.flightNum = flightNum;
                this.maxSeats = maxSeats;
                this.price = price;
            }
        }

        class MYSQLConn
        {
            private string sqlConQr = @"server=168.235.68.21;database=airplanes;userid=airplanes;password=pzUVmcb3B;";
            MySqlConnection sqlConn = null;
            MySqlDataReader sqlReader = null;
            public MYSQLConn()
            {
                // Default constructor for the SQL update class //
                sqlConn = new MySqlConnection(sqlConQr);
                sqlConn.Open();
            }
            // functions go here to access the SQL data, perform ops, etc... //

            public List<Airport> getAirports()
            {
                // Function for getting all airports from the database //
                List<Airport> Airports = new List<Airport>();
                string cmdText = "SELECT * FROM airport;" ;
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader(); // executes the reader
                string monsterImage = string.Empty;
                while (sqlReader.Read())
                {
                    Airports.Add(new Airport(sqlReader.GetString("Airport Name"), sqlReader.GetString("State"),
                        sqlReader.GetString("City"), sqlReader.GetString("IATA Code"), sqlReader.GetInt32("Runways")));
                }
                sqlReader.Close();
                return Airports;
            }

            public List<string> getRunways(string airportname)
            {
                // Function for getting all airports from the database //
                List<String> Runways = new List<String>();
                string cmdText = "SELECT * FROM runways WHERE `Airport Name` = '" + airportname + "';";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader(); // executes the reader
                string monsterImage = string.Empty;
                while (sqlReader.Read())
                {
                    Runways.Add(sqlReader.GetString("Runway Nr"));
                }
                sqlReader.Close();
                return Runways;
            }

            public List<Fare> getFares(int FlightNumber)
            {
                // Function for getting all airports from the database //
                List<Fare> Fares = new List<Fare>();
                string cmdText = "SELECT * FROM runways WHERE `Fligh Nr` = " + FlightNumber + ";";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader(); // executes the reader
                string monsterImage = string.Empty;
                while (sqlReader.Read())
                {
                    Fares.Add(new Fare(sqlReader.GetString("Class"), sqlReader.GetInt32("Flight Nr"), 
                        sqlReader.GetInt32("Max Seats"), sqlReader.GetInt32("Price")));
                }
                sqlReader.Close();
                return Fares;
            }
        }
    }
}
