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
    public partial class Delete : Form
    {
        WelcomPage frmLogin;
        public Delete(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main objMain = new Main(frmLogin);
            objMain.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbBuilding.Checked)
            {
                //delete form code
            }
            else if (rbCensus.Checked)
            {
                //delete form code
            }
            else if (rbMortgager.Checked)
            {
                //delete form code
            }
            else if (rbOwner.Checked)
            {
                //delete form code
            }
            else if (rbUnit.Checked)
            {
                //delete form code
            }
            else
            {
                MessageBox.Show("Select an option");
            }
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
                deleteGrid.AutoGenerateColumns = true;
                deleteGrid.DataSource = dataset;
                deleteGrid.DataMember = "BUILDING";
            }
            else if (this.rbCensus.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from CENSUS_TRACT;";
                adapter.Fill(dataset, "CENSUS TRACT");
                deleteGrid.AutoGenerateColumns = true;
                deleteGrid.DataSource = dataset;
                deleteGrid.DataMember = "CENSUS TRACT";
            }
            else if (this.rbMortgager.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from MORTGAGER;";
                adapter.Fill(dataset, "MORTGAGER");
                deleteGrid.AutoGenerateColumns = true;
                deleteGrid.DataSource = dataset;
                deleteGrid.DataMember = "MORTGAGER";
            }
            else if (this.rbOwner.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from OWNER;";
                adapter.Fill(dataset, "OWNER");
                deleteGrid.AutoGenerateColumns = true;
                deleteGrid.DataSource = dataset;
                deleteGrid.DataMember = "OWNER";
            }
            else if (this.rbUnit.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from UNIT;";
                adapter.Fill(dataset, "UNIT");
                deleteGrid.AutoGenerateColumns = true;
                deleteGrid.DataSource = dataset;
                deleteGrid.DataMember = "UNIT";
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
