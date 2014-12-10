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
            DataTable grid = new DataTable();
            grid.Columns.Add("Airline");
            grid.Columns.Add("Flight Nr");
            grid.Columns.Add("Departure Time");
            grid.Columns.Add("Departure Airport");
            grid.Columns.Add("Arrival Time");
            grid.Columns.Add("Arrival Airport");

            // Add schedule grid columns here //
            DataRow row = grid.Rows.Add();
            row[0] = "Ryanair";
            row[1] = "00001";
            row[2] = "TODAY";
            row[3] = "STL";
            row[4] = "CRASH";
            row[5] = "MCI";
            row.AcceptChanges();

            Schedule_Grid.DataSource = grid;
            
            
        }

        private void Schedule_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When the cell is selected by click, then it is considered the desired airport choice //
            // Set buttons to different values and prepare row data to be written back to the parent window //
            DataGridView selectedCell = (DataGridView)sender;
            selectedRowIndex = e.RowIndex;
            Schedule_FareSelect.Enabled = true;
        }

        private void Schedule_Close_Click(object sender, EventArgs e)
        {
            // Closes the form when the 'Close' button is clicked //
            // No data is sent back to the parent form application //
            this.Close();
        }
    }
}
