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
    public partial class Insert_Unit : Form
    {
        WelcomPage frmLogin;
        public Insert_Unit(WelcomPage objLogin)
        {
            InitializeComponent();

            this.frmLogin = objLogin;
        }
        public bool check_BuildingID()
        {

            
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            bool Building_ID_exists = true;
            try
            {

                SqlCommand newCommand = new SqlCommand("SELECT c.Building_ID FROM Building c WHERE c.Building_ID= '" + txt_buildingID.Text + "'", openConnection);
                sqlDataAdapter.SelectCommand = newCommand;
                sqlDataAdapter.Fill(newDataSet, "Building_ID_exits");
                if (newDataSet.Tables[0].Rows.Count > 0)
                {
                    int db_Building_ID = int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
                    Building_ID_exists = true;
                }
                else
                {
                    Building_ID_exists = false;
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
                Building_ID_exists = false;
            }
            return Building_ID_exists;

        }
        public int fetch_Unit_ID()
        {
            int Unit_ID = 0;
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();


            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            SqlCommand newCommand = new SqlCommand("SELECT MAX(c.Unit_ID) FROM Unit C", openConnection);
            sqlDataAdapter.SelectCommand = newCommand;
            sqlDataAdapter.Fill(newDataSet, "max_Unit_ID");

            Unit_ID = 1 + int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
            sqlDataAdapter.Dispose();
            newDataSet.Dispose();
            openConnection.Close();

            return Unit_ID;

        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();

            int Unit_ID = fetch_Unit_ID();
            bool Unit_ID_exists = check_BuildingID();
            Unit_ID_exists = true; 
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);

            try
            {
                openConnection.Open();
                if (Unit_ID_exists)
                {


                    string insertQuery = "INSERT INTO UNIT VALUES" +
                        "(@Unit_ID,@Building_ID,@Type,@Building_ocation,@Size_square_foot,@Num_Baths,@Kitchen_and_dinning,@Special_Remarks,@Avg_Occupancy,@Occupied)";


                    SqlCommand insertCommand = new SqlCommand(insertQuery, openConnection);

                    insertCommand.Parameters.Add("@Unit_ID", SqlDbType.Int, 4).Value = Unit_ID;
                    insertCommand.Parameters.Add("@Building_ID", SqlDbType.Char, 4).Value = txt_buildingID;
                    insertCommand.Parameters.Add("@Type", SqlDbType.Char, 15).Value = txt_BuildingType.Text;
                    insertCommand.Parameters.Add("@Building_ocation", SqlDbType.Char, 50).Value = txt_location.Text;
                    insertCommand.Parameters.Add("@Size_square_foot", SqlDbType.Int, 30).Value = txt_Size.Text;
                    insertCommand.Parameters.Add("@Num_Baths", SqlDbType.Char, 35).Value = txt_bathrooms.Text;
                    insertCommand.Parameters.Add("@Kitchen_and_dinning", SqlDbType.Char, 35).Value = txt_Kitchen.Text;
                    insertCommand.Parameters.Add("@Special_Remarks", SqlDbType.Char, 300).Value = txt_Remarks.Text;
                    insertCommand.Parameters.Add("@Avg_Occupancy", SqlDbType.Char, 5).Value = txt_avgOccupancy.Text;
                    insertCommand.Parameters.Add("@Occupied", SqlDbType.Bit, 12).Value = txt_Occupied.Text;

                    int count = insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Unit details inserted succesfully with Unit ID = " + Unit_ID);
                    insertCommand.Dispose();

                    sqlDataAdapter.Dispose();
                    newDataSet.Dispose();
                    openConnection.Close();

                }
                else
                {
                    MessageBox.Show("Please insert data into Building table first with Building id " + txt_buildingID.Text);
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert objInsert = new Insert(frmLogin);
            objInsert.Show();
        }
    }
}
