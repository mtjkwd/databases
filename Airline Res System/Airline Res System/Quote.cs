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
    public partial class Quote : Form
    {
        public Quote()
        {
            InitializeComponent();
        }

        private void Quote_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
