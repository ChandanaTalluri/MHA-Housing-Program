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


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textboxContainsValidText(txt_MortgagerID) && validPrimaryKey(txt_MortgagerID.Text))
            {
                string update = "update Mortgager set ";
                string where = " where Mortgager_ID = '" + txt_MortgagerID.Text + "'";
                string command;

                //Update columns where textbox has valid input.
                if (textboxContainsValidText(txt_Name))
                {
                    command = update + "Name = '" + txt_Name.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Name column could not be updated."); }
                }
                if (textboxContainsValidText(txt_PhoneNumber))
                {
                    command = update + "Phone_Num = '" + txt_PhoneNumber.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Phone_Num column could not be updated."); }
                }
                if (textboxContainsValidText(txt_StreetAddress))
                {
                    command = update + "Street_Address = '" + txt_StreetAddress.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Street_Address column could not be updated."); }
                }
                if (textboxContainsValidText(txt_City))
                {
                    command = update + "City = '" + txt_City.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The City column could not be updated."); }
                }
                if (textboxContainsValidText(txt_State))
                {
                    command = update + "State = '" + txt_State.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The State column could not be updated."); }
                }
                if (textboxContainsValidText(txt_PostalCode))
                {
                    command = update + "Postal_Code = '" + txt_PostalCode.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Postal_Code column could not be updated."); }
                }
            }
            else
            {
                MessageBox.Show("The primary key provided is not valid.", "Error");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update(loginForm);
            updateForm.Show();
            this.Close();
        }
    }
}
