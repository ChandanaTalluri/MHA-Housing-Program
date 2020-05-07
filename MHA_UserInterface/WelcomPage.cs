using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MHA_UserInterface
{
    public partial class WelcomPage : Form
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        private void WelcomPage_Load(object sender, EventArgs e)
        {

        }

        public string ConnString()
        {
            //These values should not be hard-coded in.
            string userID = txt_userID.Text;
            string userPassword = txt_Password.Text;
            string databaseName = txt_DatabaseName.Text;
            string serverName = txt_ServerName.Text;

            string connectionString = "Data Source=" + serverName + "; Initial Catalog=" + databaseName + "; User ID=" + userID + "; Password=" + userPassword + ";";
            return connectionString;
        }
        public bool CheckConnection()
        {
            bool worked;
            string ctnString = ConnString();
            SqlConnection openConnection;
            openConnection = new SqlConnection(ctnString);
            try
            {
                openConnection.Open();

                worked = true;

                openConnection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                worked = false;
                openConnection.Close();
            }
            return worked;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool connectionOpen = CheckConnection();
            if (connectionOpen)
            {
                this.Hide();
                Main main1 = new Main(this);
                main1.Show();
            }
            else
            {
                MessageBox.Show("It didn't work");
            }
        }
    }
}
