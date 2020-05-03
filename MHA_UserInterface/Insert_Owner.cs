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
    public partial class Insert_Owner : Form
    {
        WelcomPage frmLogin;
        public Insert_Owner(WelcomPage objLogin)
        {
            InitializeComponent();
            
            this.frmLogin = objLogin;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert objInsert = new Insert(frmLogin);
            objInsert.Show();
        }

        private void Insert_Owner_Load(object sender, EventArgs e)
        {

        }
        public int fetch_Owner_ID()
        {
            int Owner_ID = 0;
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();


            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            SqlCommand newCommand = new SqlCommand("SELECT MAX(c.Owner_ID) FROM Owner C", openConnection);
            sqlDataAdapter.SelectCommand = newCommand;
            sqlDataAdapter.Fill(newDataSet, "max_Owner_ID");

            Owner_ID = 1 + int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
            sqlDataAdapter.Dispose();
            newDataSet.Dispose();
            openConnection.Close();

            return Owner_ID;

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            int Owner_ID = fetch_Owner_ID();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);

            try
            {
                openConnection.Open();
                string insertQuery = "INSERT INTO Owner VALUES" +
                        "(@Owner_ID,@First_name,@Last_Name,@Phone_num,@Street_address,@City,@State,@Postal_code)";


                SqlCommand insertCommand = new SqlCommand(insertQuery, openConnection);


                insertCommand.Parameters.Add("@Owner_ID", SqlDbType.Int, 30).Value = Owner_ID;
                insertCommand.Parameters.Add("@First_name", SqlDbType.Char, 20).Value = txt_first_name.Text;
                insertCommand.Parameters.Add("@Last_Name", SqlDbType.Char, 20).Value = txt_LastName.Text;
                insertCommand.Parameters.Add("@Phone_num", SqlDbType.Char, 15).Value = txt_PhoneNumber.Text;
                insertCommand.Parameters.Add("@Street_address", SqlDbType.Char, 30).Value = txt_Address.Text;
                insertCommand.Parameters.Add("@City", SqlDbType.Char, 30).Value = txt_City.Text;
                insertCommand.Parameters.Add("@State", SqlDbType.Char, 2).Value = txt_State.Text;
                insertCommand.Parameters.Add("@Postal_Code", SqlDbType.Char, 10).Value = txt_PostalCode.Text;

                int count = insertCommand.ExecuteNonQuery();
                MessageBox.Show("Owner details inserted succesfully with Owner ID = " + Owner_ID);
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
    }
}
