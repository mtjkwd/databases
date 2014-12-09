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
            // SAMPLE FUNCTION BELOW TO SHOW THESE CALLS IN C# //
            public string getMonsterImage(string monsterName)
            {
                // Function for getting the picture name / location data from the MonsterAttr table //
                string cmdText = "SELECT Picture FROM Software_Engineering.MonsterAttr "
                    + "WHERE Name = '" + monsterName.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(cmdText, sqlConn);
                sqlReader = cmd.ExecuteReader(); // executes the reader
                string monsterImage = string.Empty;
                while (sqlReader.Read())
                {
                    monsterImage = sqlReader.GetString("Picture");
                }
                sqlReader.Close();
                return ("./EncounterImages/" + monsterImage.ToString());
            }
        }
    }
}
