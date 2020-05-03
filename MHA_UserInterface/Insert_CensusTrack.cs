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
    public partial class Insert_CensusTrack : Form
    {

        WelcomPage frmLogin;
        InsertBuilding insBuilding;
        public Insert_CensusTrack(WelcomPage objLogin,InsertBuilding obj_inert_Building)
        {

            InitializeComponent();
            this.frmLogin = objLogin;
            this.insBuilding = obj_inert_Building;

        }
        public Insert_CensusTrack(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;

        }
        public int fetch_TackID()
        {
            int trackID = 0;
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();


            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            SqlCommand newCommand = new SqlCommand("SELECT MAX(c.Tract_ID) FROM Census_Tract C", openConnection);
            sqlDataAdapter.SelectCommand = newCommand;
            sqlDataAdapter.Fill(newDataSet, "Max_Tract_ID");

            trackID = 1 + int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
            sqlDataAdapter.Dispose();
            newDataSet.Dispose();
            openConnection.Close();

            return trackID;

        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);

            try
            {
                openConnection.Open();

                string insertQuery = "INSERT INTO Census_Tract VALUES(@Tract_ID,@Demographic_data,@Median_income)";


                SqlCommand insertCommand = new SqlCommand(insertQuery, openConnection);

                int trackID = fetch_TackID();
                insertCommand.Parameters.Add("@Tract_ID", SqlDbType.Char, 4).Value = trackID;
                // need to check and covert it to var binary

                var byteArray = Encoding.ASCII.GetBytes(txt_Demographic.Text);
                insertCommand.Parameters.Add("@Demographic_data", SqlDbType.VarBinary, byteArray.Length).Value = byteArray;
                insertCommand.Parameters.Add("@Median_income", SqlDbType.Char, 30).Value = txt_MedianIncome.Text;
               

                int count = insertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted succesfully with Census Track ID as "+trackID);
                insertCommand.Dispose();

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
