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
    public partial class InsertBuilding : Form
    {
        WelcomPage frmLogin;
        InsertBuilding building;
        public InsertBuilding(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InserBuilding_Load(object sender, EventArgs e)
        {

        }
        public int fetch_buildingID()
        {
            int buildingID = 0;
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();


            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            SqlCommand newCommand = new SqlCommand("SELECT MAX(b.Building_ID) FROM Building b", openConnection);
            sqlDataAdapter.SelectCommand = newCommand;
            sqlDataAdapter.Fill(newDataSet, "Max_Building_ID");

            buildingID = 1 + int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());

            sqlDataAdapter.Dispose();
            newDataSet.Dispose();
            openConnection.Close();
            return buildingID;

        }
        public bool check_MortgagerID()
        {
            int Mortgager_ID = int.Parse(txt_MartgagerID.Text.ToString());
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            bool Mortgager_ID_exists = true;
            try
            {
                SqlCommand newCommand = new SqlCommand("SELECT m.Mortgager_ID FROM Mortgager m WHERE m.Mortgager_ID= '" + txt_MartgagerID.Text + "'", openConnection);
                sqlDataAdapter.SelectCommand = newCommand;
                sqlDataAdapter.Fill(newDataSet, "Census_id_exits");
                if (newDataSet.Tables[0].Rows.Count > 0)
                {
                    int db_Mortgager_ID = int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
                    sqlDataAdapter.Dispose();
                    newDataSet.Dispose();
                    openConnection.Close();
                }
                else
                {
                    Mortgager_ID_exists = false;
                }

                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();
                Mortgager_ID_exists = false;
            }
            return Mortgager_ID_exists;
           
        }
        public bool check_CensusTrackID()
        {
            
            int tarckId = int.Parse(txt_CensusID.Text.ToString());
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            bool trackID_exists = true;
            try
            {
                
                SqlCommand newCommand = new SqlCommand("SELECT c.Tract_ID FROM Census_Tract c WHERE c.Tract_ID= '" + txt_CensusID.Text + "'", openConnection);
                sqlDataAdapter.SelectCommand = newCommand;
                sqlDataAdapter.Fill(newDataSet, "Census_id_exits");
                if (newDataSet.Tables[0].Rows.Count > 0)
                {
                    int db_tarckId = int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
                        trackID_exists = true;  
                }
                else
                {
                    trackID_exists = false;
                }
                
                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();
                trackID_exists = false;
            }
            return trackID_exists;

        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();

            int buildingID = fetch_buildingID();
            bool trackID_exists = check_CensusTrackID();
            bool MortgagerID_exists = check_MortgagerID();
            //if track id is new then first we nned to insert data into census track

            
            trackID_exists = true;  MortgagerID_exists = true;
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);

            try
            {
                openConnection.Open();
                if (trackID_exists && MortgagerID_exists)
                {

                
                string insertQuery = "INSERT INTO BUILDING VALUES" +
                    "(@Building_ID,@Tract_ID,@Mortgager_ID,@Name,@Street_address,@City,@State,@Postal_code,@Size_square_feet,@Renovations_and_repairs,@Handicap_accessible)";


                SqlCommand insertCommand = new SqlCommand(insertQuery, openConnection);


                insertCommand.Parameters.Add("@Building_ID", SqlDbType.Char, 4).Value = buildingID;
                insertCommand.Parameters.Add("@Tract_ID", SqlDbType.Char, 30).Value = txt_CensusID.Text;
                insertCommand.Parameters.Add("@Mortgager_ID", SqlDbType.Char, 30).Value = txt_MartgagerID.Text;
                    insertCommand.Parameters.Add("@Name", SqlDbType.Char, 30).Value = txt_name.Text;
                    insertCommand.Parameters.Add("@Street_address", SqlDbType.Char, 35).Value = txt_Address.Text;
                insertCommand.Parameters.Add("@City", SqlDbType.Char, 35).Value = txt_City.Text;
                insertCommand.Parameters.Add("@State", SqlDbType.Char, 2).Value = txt_State.Text;
                insertCommand.Parameters.Add("@Postal_Code", SqlDbType.Char, 5).Value = txt_PostalCode.Text;
                insertCommand.Parameters.Add("@Size_square_feet", SqlDbType.Char, 12).Value = txt_Size.Text;
                insertCommand.Parameters.Add("@Renovations_and_repairs", SqlDbType.Char, 12).Value = txt_Repair.Text;
                insertCommand.Parameters.Add("@Handicap_accessible", SqlDbType.Char, 12).Value = txt_Handicap.Text;

                int count = insertCommand.ExecuteNonQuery();
                MessageBox.Show("Building details inserted succesfully with Building ID = "+buildingID);
                insertCommand.Dispose();

                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();

                }
                else if(trackID_exists && !MortgagerID_exists)
                {
                    MessageBox.Show("Please insert data into Mortgager first with Mortgager ID" + txt_MartgagerID.Text);
                }
                else if (!trackID_exists && MortgagerID_exists)
                {
                    MessageBox.Show("Please insert data into census track first with track id " + txt_CensusID.Text);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                sqlDataAdapter.Dispose();
                newDataSet.Dispose();
                openConnection.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert objInsert = new Insert(frmLogin);
            objInsert.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
