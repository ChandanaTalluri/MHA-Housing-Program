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
    public partial class Update : Form
    {
        WelcomPage frmLogin;
        public Update(WelcomPage objLogin)
        {
            InitializeComponent();
            this.frmLogin = objLogin;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main objMain = new Main(frmLogin);
            objMain.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string searchConnectionString = frmLogin.ConnString();
            SqlConnection openConnection = new SqlConnection(searchConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();

            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = openConnection;
            openConnection.Open();
            if (this.rbBuilding.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from BUILDING;";
                adapter.Fill(dataset, "BUILDING");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "BUILDING";
            }
            else if (this.rbCensus.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from CENSUS_TRACT;";
                adapter.Fill(dataset, "CENSUS TRACT");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "CENSUS TRACT";
            }
            else if (this.rbMortgager.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from MORTGAGER;";
                adapter.Fill(dataset, "MORTGAGER");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "MORTGAGER";
            }
            else if (this.rbOwner.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from OWNER;";
                adapter.Fill(dataset, "OWNER");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "OWNER";
            }
            else if (this.rbUnit.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from UNIT;";
                adapter.Fill(dataset, "UNIT");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "UNIT";
            }
            else
            {
                MessageBox.Show("Please select an option");
            }
            openConnection.Close();
            adapter.Dispose();
            dataset.Dispose();
        }
    }
}
