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
        WelcomPage loginForm;
        public Update(WelcomPage newLoginForm)
        {
            InitializeComponent();
            this.loginForm = newLoginForm;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main objMain = new Main(loginForm);
            objMain.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string searchConnectionString = loginForm.ConnString();
            SqlConnection openConnection = new SqlConnection(searchConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();

            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = openConnection;
            openConnection.Open();
            if (this.rbtn_Building.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from BUILDING;";
                adapter.Fill(dataset, "BUILDING");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "BUILDING";
            }
            else if (this.rbtn_CensusTract.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from CENSUS_TRACT;";
                adapter.Fill(dataset, "CENSUS TRACT");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "CENSUS TRACT";
            }
            else if (this.rbtn_Mortgager.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from MORTGAGER;";
                adapter.Fill(dataset, "MORTGAGER");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "MORTGAGER";
            }
            else if (this.rbtn_Owner.Checked)
            {
                adapter.SelectCommand.CommandText = "select * from OWNER;";
                adapter.Fill(dataset, "OWNER");
                insertGrid.AutoGenerateColumns = true;
                insertGrid.DataSource = dataset;
                insertGrid.DataMember = "OWNER";
            }
            else if (this.rbtn_Unit.Checked)
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (rbtn_Building.Checked)
            {
                Update_Building newForm = new Update_Building(this.loginForm);
                newForm.Show();
                this.Close();
            }
            else if (rbtn_CensusTract.Checked)
            {
                Update_CensusTrack newForm = new Update_CensusTrack(this.loginForm);
                newForm.Show();
                this.Close();
            }
            else if (rbtn_Mortgager.Checked)
            {
                Update_Mortgager newForm = new Update_Mortgager(this.loginForm);
                newForm.Show();
                this.Close();
            }
            else if (rbtn_Owner.Checked)
            {
                Update_Owner newForm = new Update_Owner(this.loginForm);
                newForm.Show();
                this.Close();
            }
            else if (rbtn_Unit.Checked)
            {
                Update_Unit newForm = new Update_Unit(this.loginForm);
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }
        }
    }
}
