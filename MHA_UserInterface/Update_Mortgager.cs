using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Required for SQL.
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MHA_UserInterface
{
    public partial class Update_Mortgager : Form
    {
        private WelcomPage loginForm;

        public Update_Mortgager(WelcomPage newLoginForm)
        {
            InitializeComponent();
            this.loginForm = newLoginForm;
        }

        private bool updateWithSQL(string updateStatement)
        {
            bool updateSuccess;

            string connectionString = loginForm.ConnString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand(); //Create a new command.
                command.CommandText = updateStatement; //Set the SQL to execute.
                command.Connection = sqlConnection; //Connect to the database.
                command.ExecuteNonQuery();

                updateSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database. Exception details: \n\n" + ex.Message);
                updateSuccess = false;
            }
            sqlConnection.Close();
            return updateSuccess;
        }

        private bool validPrimaryKey(string key)
        {
            try
            {
                int temp = Int32.Parse(key); //Test if the string can be converted to an integer.
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool textboxContainsValidText(TextBox txt)
        {
            if (txt.Text.Length == 0) { return false; }

            //SQL injection prevention.
            if (txt.Text.Contains("'")) { return false; }
            if (txt.Text.Contains("--")) { return false; }

            return true;
        }


        private void Update_Mortgager_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textboxContainsValidText(txt_MortgagerID) && validPrimaryKey(txt_MortgagerID.Text))
            {

            }
            else
            {
                MessageBox.Show("The primary key provided is not valid.", "Error");
            }
        }
    }
}
