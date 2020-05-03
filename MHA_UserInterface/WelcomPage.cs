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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void WelcomPage_Load(object sender, EventArgs e)
        {

        }
        public string ConnString()
        {
            string UserID, UserPassword, DatabaseName, ServerName;
            string connectionString;
            UserID = txt_userID.Text;
            UserPassword = txt_Password.Text;
            DatabaseName = "MHA";
            //ServerName = "DESKTOP-QQAP9VT\\SQLEXPRESS";
            //ServerName = "HPASS-CART19-L";
            connectionString = "Data Source=" + ServerName + "; Initial Catalog=" + DatabaseName + "; User ID=" + UserID + "; Password=" + UserPassword + ";";


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
