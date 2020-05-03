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

    public partial class Insert : Form
    {
        WelcomPage frmLogin;
        public Insert(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;
        }
        private void ins_Bulding_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertBuilding objInsertBuilding = new InsertBuilding(frmLogin);
            objInsertBuilding.Show();
        }

        private void ins_CensusTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_CensusTrack obj_Insert_Tract = new Insert_CensusTrack(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void btn_insMortgager_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertMortgager obj_Insert_Tract = new InsertMortgager(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ins_owner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Owner obj_Insert_Tract = new Insert_Owner(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void btn_Unit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Unit obj_Insert_Tract = new Insert_Unit(frmLogin);
            obj_Insert_Tract.Show();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (rbBuilding.Checked)
            {
                this.Hide();
                InsertBuilding objInsertBuilding = new InsertBuilding(frmLogin);
                objInsertBuilding.Show();
            }
            else if (rbCensus.Checked)
            {
                this.Hide();
                Insert_CensusTrack obj_Insert_Tract = new Insert_CensusTrack(frmLogin);
                obj_Insert_Tract.Show();
            }
            else if (rbMortgager.Checked)
            {
                this.Hide();
                InsertMortgager obj_Insert_Tract = new InsertMortgager(frmLogin);
                obj_Insert_Tract.Show();
            }
            else if (rbOwner.Checked)
            {
                this.Hide();
                Insert_Owner obj_Insert_Tract = new Insert_Owner(frmLogin);
                obj_Insert_Tract.Show();
            }
            else if (rbUnit.Checked)
            {
                this.Hide();
                Insert_Unit obj_Insert_Tract = new Insert_Unit(frmLogin);
                obj_Insert_Tract.Show();
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
