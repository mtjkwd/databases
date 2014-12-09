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
