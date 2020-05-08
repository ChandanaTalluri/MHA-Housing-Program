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
    public partial class Update_Unit : Form
    {
        private WelcomPage loginForm;

        public Update_Unit(WelcomPage newLoginForm)
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


        private void Update_Unit_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textboxContainsValidText(txt_UnitID) && validPrimaryKey(txt_UnitID.Text))
            {
                string update = "update Unit set ";
                string where = " where Unit_ID = '" + txt_UnitID.Text + "'";
                string command;

                //Update columns where textbox has valid input.
                if (textboxContainsValidText(txt_BuildingID))
                {
                    command = update + "Building_ID = '" + txt_BuildingID.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Building_ID column could not be updated."); }
                }
                if (textboxContainsValidText(txt_UnitType))
                {
                    command = update + "Type = '" + txt_UnitType.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Type column could not be updated."); }
                }
                if (textboxContainsValidText(txt_LocationInBuilding))
                {
                    command = update + "Building_Location = '" + txt_LocationInBuilding.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Building_Location column could not be updated."); }
                }
                if (textboxContainsValidText(txt_SizeSquareFeet))
                {
                    command = update + "Size_Square_Feet = '" + txt_SizeSquareFeet.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Size_Square_Feet column could not be updated."); }
                }
                if (textboxContainsValidText(txt_NumBaths))
                {
                    command = update + "Num_Baths = '" + txt_NumBaths.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Num_Baths column could not be updated."); }
                }
                if (textboxContainsValidText(txt_KitchenAndDining))
                {
                    command = update + "Kitchen_and_Dining = '" + txt_KitchenAndDining.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Kitchen_and_Dining column could not be updated."); }
                }
                if (textboxContainsValidText(txt_SpecialRemarks))
                {
                    command = update + "Special_Remarks = '" + txt_SpecialRemarks.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Special_Remarks column could not be updated."); }
                }
                if (textboxContainsValidText(txt_AvgOccupancy))
                {
                    command = update + "Avg_Occupancy = '" + txt_AvgOccupancy.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Avg_Occupancy column could not be updated."); }
                }
                if (textboxContainsValidText(txt_Occupied))
                {
                    command = update + "Occupied = '" + txt_Occupied.Text + "'" + where;
                    if (!updateWithSQL(command)) { MessageBox.Show("The Occupied column could not be updated."); }
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
