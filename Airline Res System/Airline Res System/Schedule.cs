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
    public partial class Schedule : Form
    {
        private int selectedRowIndex;

        public Schedule()
        {
            InitializeComponent(); 
        }

        private void Schedule_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When the cell is selected by click, then it is considered the desired airport choice //
            // Set buttons to different values and prepare row data to be written back to the parent window //
            DataGridView selectedCell = (DataGridView)sender;
            selectedRowIndex = e.RowIndex;
            Schedule_Buy.Enabled = true;
            Schedule_BookingClass.Enabled = true;
            Schedule_NumPass.Enabled = true;
            Schedule_PassEmail.Enabled = true;
            Schedule_Fname.Enabled = true;
            Schedule_Lname.Enabled = true;
        }

        private void Schedule_Close_Click(object sender, EventArgs e)
        {
            // Closes the form when the 'Close' button is clicked //
            // No data is sent back to the parent form application //
            this.Close();
        }

        private void Schedule_FareSelect_Click(object sender, EventArgs e)
        {
            // When the 'choose' button is clicked, do this //
            // Cell 0 = Airline
            // Cell 1 = flight number
            // cell 2 = dept. airport
            // cell 3 = dept. time
            // cell 4 = arr. airport
            // cell 5 = arr. time
            // cell 6 = total seats

            Control[] Schedule_GridControl = this.Controls.Find("Schedule_Grid", true);
            DataGridView Schedule_Grid = (DataGridView)Schedule_GridControl[0];
            try
            {
                string airline = Schedule_Grid.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string flightNr = Schedule_Grid.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string deptAir = Schedule_Grid.Rows[selectedRowIndex].Cells[2].Value.ToString();
                string depTime = Schedule_Grid.Rows[selectedRowIndex].Cells[3].Value.ToString();
                string arrAir = Schedule_Grid.Rows[selectedRowIndex].Cells[4].Value.ToString();
                string arrTime = Schedule_Grid.Rows[selectedRowIndex].Cells[5].Value.ToString();
                string email = this.Schedule_PassEmail.Text.ToString();
                string fname = this.Schedule_Fname.Text.ToString();
                string lname = this.Schedule_Lname.Text.ToString();
                string fareClass = this.Schedule_BookingClass.Text.ToString();
                

                // Write items out to the SQL table, then display success message //
                MYSQLConn connection = new MYSQLConn();
                int ticketNr = connection.getNewTicketNum(Convert.ToInt32(flightNr));
                connection.purchaseTicket(ticketNr, email, Convert.ToInt32(flightNr), ticketNr, fareClass, airline);
                MessageBox.Show("Booking Complete!");
                
            }
            catch (NullReferenceException)
            {
                string airline = String.Empty;
                string flightNr = string.Empty;
                string deptAir = string.Empty;
                string depTime = string.Empty;
                string arrAir = string.Empty;
                string arrTime = string.Empty;

            }
            

        }
    }
}
