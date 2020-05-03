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
    public partial class InsertMortgager : Form
    {
        WelcomPage frmLogin;
        public InsertMortgager(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;

        }
        public int fetch_Mortgager_ID()
        {
            int Mortgager_ID = 0;
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();


            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);
            SqlCommand newCommand = new SqlCommand("SELECT MAX(c.Mortgager_ID) FROM Mortgager C", openConnection);
            sqlDataAdapter.SelectCommand = newCommand;
            sqlDataAdapter.Fill(newDataSet, "max_Mortgager_ID");

            Mortgager_ID = 1 + int.Parse(newDataSet.Tables[0].Rows[0][0].ToString());
            sqlDataAdapter.Dispose();
            newDataSet.Dispose();
            openConnection.Close();

            return Mortgager_ID;

        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string serachConnectionString;
            SqlConnection openConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet newDataSet = new DataSet();
            int mortgagerID = fetch_Mortgager_ID();
            serachConnectionString = frmLogin.ConnString();
            openConnection = new SqlConnection(serachConnectionString);

            try
            {
                openConnection.Open();
                string insertQuery = "INSERT INTO Mortgager VALUES" +
                        "(@Mortgager_ID,@Name,@Phone_num,@Street_address,@City,@State,@Postal_code)";


                    SqlCommand insertCommand = new SqlCommand(insertQuery, openConnection);


                    insertCommand.Parameters.Add("@Mortgager_ID", SqlDbType.Char, 30).Value = mortgagerID;
                insertCommand.Parameters.Add("@Name", SqlDbType.Char, 30).Value = txt_name.Text;
                insertCommand.Parameters.Add("@Phone_num", SqlDbType.Char, 30).Value = txt_PhoneNumber.Text;
                insertCommand.Parameters.Add("@Street_address", SqlDbType.Char, 35).Value = txt_Address.Text;
                    insertCommand.Parameters.Add("@City", SqlDbType.Char, 35).Value = txt_City.Text;
                    insertCommand.Parameters.Add("@State", SqlDbType.Char, 2).Value = txt_State.Text;
                    insertCommand.Parameters.Add("@Postal_Code", SqlDbType.Char, 5).Value = txt_PostalCode.Text;
                   
                    int count = insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Mortgager details inserted succesfully with Mortgager ID = " + mortgagerID);
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
