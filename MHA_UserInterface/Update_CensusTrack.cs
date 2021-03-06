﻿using System;
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
    public partial class Update_CensusTrack : Form
    {
        private WelcomPage loginForm;

        public Update_CensusTrack(WelcomPage newLoginForm)
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
            if (textboxContainsValidText(txt_TractID) && validPrimaryKey(txt_TractID.Text))
            {
                string update = "update Census_Tract set ";
                string where = " where tract_ID = '" + txt_TractID.Text + "'";
                string command;

                //Update columns where textbox has valid input.
                if (textboxContainsValidText(txt_MedianIncome))
                {
                    command = update + "Median_income = '" + txt_MedianIncome.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Median_Income column could not be updated."); }
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
