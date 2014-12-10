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
            public Airport(string name, string state, string city, string iata, int runwayCount)
            {
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
            public Fare(string Class, int flightNum, int maxSeats, int price)
            {
                this.Class = Class;
                this.flightNum = flightNum;
                this.maxSeats = maxSeats;
                this.price = price;
            }
        }

        class Flight
        {
            public int flightNum;
            public string airline;
            public int maxSeats;
            public string status;
            public string arrDate;
            public string depDate;
            public string depTime;
            public string arrTime;
            public string depAirport;
            public string arrAirport;

            public Flight(int flightNum, string airline, int maxSeats, string status, string arrDate, string arrTime,
                string depDate, string depTime, string depAirport, string arrAirport)
            {
                this.flightNum = flightNum;
                this.airline = airline;
                this.maxSeats = maxSeats;
                this.status = status;
                this.arrDate = arrDate;
                this.arrTime = arrTime;
                this.depDate = depDate;
                this.depTime = depTime;
                this.depAirport = depAirport;
                this.arrAirport = arrAirport;
            }
        }

        class Ticket
        {
            public int ticketNum;
            public string email;
            public int flightNum;
            public int seatNum;
            public string fareClass;
            public string airline;

            public Ticket(int ticketNum, string email, int flightNum, int seatNum, string fareClass, string airline)
            {
                this.ticketNum = ticketNum;
                this.email = email;
                this.flightNum = flightNum;
                this.seatNum = seatNum;
                this.fareClass = fareClass;
                this.airline = airline;
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
                sqlReader = cmd.ExecuteReader();
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
                // Function for getting all runways for an airport from the database //
                List<String> Runways = new List<String>();
                string cmdText = "SELECT * FROM runways WHERE `Airport Name` = '" + airportname + "';";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Runways.Add(sqlReader.GetString("Runway Nr"));
                }
                sqlReader.Close();
                return Runways;
            }

            public List<Fare> getFares(int FlightNumber)
            {
                // Function for getting all fares for a flight number from the database //
                List<Fare> Fares = new List<Fare>();
                string cmdText = "SELECT * FROM runways WHERE `Fligh Nr` = " + FlightNumber + ";";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Fares.Add(new Fare(sqlReader.GetString("Class"), sqlReader.GetInt32("Flight Nr"), 
                        sqlReader.GetInt32("Max Seats"), sqlReader.GetInt32("Price")));
                }
                sqlReader.Close();
                return Fares;
            }

            public List<Flight> getFlights()
            {
                // Function for getting all flights from the database //
                List<Flight> Flights = new List<Flight>();
                string cmdText = "SELECT * FROM flight;";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Flights.Add(new Flight(sqlReader.GetInt32("Flight Nr"), sqlReader.GetString("Airline"), sqlReader.GetInt32("Max Seats"), sqlReader.GetString("Status"), 
                        sqlReader.GetString("Arr_Date"), sqlReader.GetString("Arr_Date"), sqlReader.GetString("Dep_Date"), sqlReader.GetString("Dep_Time"), 
                        sqlReader.GetString("Dep_Airport"), sqlReader.GetString("Arr_Airport")));
                }
                sqlReader.Close();
                return Flights;
            }

            public List<Flight> getFlights(string date)
            {
                // Function for getting all flights for a date from the database //
                List<Flight> Flights = new List<Flight>();
                string cmdText = "SELECT * FROM flight WHERE Dep_Date = '" + date +"';";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Flights.Add(new Flight(sqlReader.GetInt32("Flight Nr"), sqlReader.GetString("Airline"), sqlReader.GetInt32("Max Seats"), sqlReader.GetString("Status"),
                        sqlReader.GetString("Arr_Date"), sqlReader.GetString("Arr_Date"), sqlReader.GetString("Dep_Date"), sqlReader.GetString("Dep_Time"),
                        sqlReader.GetString("Dep_Airport"), sqlReader.GetString("Arr_Airport")));
                }
                sqlReader.Close();
                return Flights;
            }

            public List<Flight> getFlightsAfterDate(string date)
            {
                // Function for getting all flights after a date from the database //
                List<Flight> Flights = new List<Flight>();
                string cmdText = "SELECT * FROM flight WHERE Dep_Date > '" + date + "';";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Flights.Add(new Flight(sqlReader.GetInt32("Flight Nr"), sqlReader.GetString("Airline"), sqlReader.GetInt32("Max Seats"), sqlReader.GetString("Status"),
                        sqlReader.GetString("Arr_Date"), sqlReader.GetString("Arr_Date"), sqlReader.GetString("Dep_Date"), sqlReader.GetString("Dep_Time"),
                        sqlReader.GetString("Dep_Airport"), sqlReader.GetString("Arr_Airport")));
                }
                sqlReader.Close();
                return Flights;
            }

            public Flight getFlight(int flightNum)
            {
                // Function for getting a flight by a flight number for a date from the database - CAN RETURN NULL//
                Flight flight = null;
                string cmdText = "SELECT * FROM flight WHERE `Flight Nr` = '" + flightNum + "';";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    flight = new Flight(sqlReader.GetInt32("Flight Nr"), sqlReader.GetString("Airline"), sqlReader.GetInt32("Max Seats"), sqlReader.GetString("Status"),
                        sqlReader.GetString("Arr_Date"), sqlReader.GetString("Arr_Date"), sqlReader.GetString("Dep_Date"), sqlReader.GetString("Dep_Time"),
                        sqlReader.GetString("Dep_Airport"), sqlReader.GetString("Arr_Airport")));
                }
                sqlReader.Close();
                return flight;
            }

            public List<Ticket> getTickets(int flightNum)
            {
                // Function for getting all tickets for a flightNum from the database //
                List<Ticket> Tickets = new List<Ticket>();
                string cmdText = "SELECT * FROM ticket WHERE `Flight Nr` = " + flightNum + ";";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Tickets.Add(new Ticket(sqlReader.GetInt32("Ticket Nr"), sqlReader.GetString("Passenger Email"), sqlReader.GetInt32("Flight Nr"), sqlReader.GetInt32("Seat Nr"),
                        sqlReader.GetString("Fare Class"), sqlReader.GetString("Airline")));
                }
                sqlReader.Close();
                return Tickets;
            }

            public void addPassenger(string email, string fname, string lname, string frequentflier)
            {
                // Function for adding a Passenger to the database, will ignore duplicate emails automatically //
                List<Flight> Flights = new List<Flight>();
                string cmdText = "INSERT IGNORE INTO passenger (Email, Fname, Lname, FrequentFlier) VALUES ('" + email + "', '" +
                    fname + "', '" + lname + "', '" + frequentflier + "');";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                cmd.ExecuteNonQuery();
                return;
            }

            public void purchaseTicket(int ticketNum, string email, int flightNum, int seatNum, string fareClass, string airline)
            {
                // Function for purchasing a ticket and logging it in the database //
                List<Flight> Flights = new List<Flight>();
                string cmdText = "INSERT INTO ticket VALUES ('" + ticketNum + "', '" +
                    email + "', '" + flightNum + "', '" + seatNum + "', '" + fareClass + "', '" + airline + "');";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                cmd.ExecuteNonQuery();
                return;
            }

        }
    }
}
