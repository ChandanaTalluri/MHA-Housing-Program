using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHA_UserInterface
{
    public partial class Delete_CensusTrack : Form
    {
        WelcomPage page;
        public Delete_CensusTrack(WelcomPage page)
        {
            InitializeComponent();
            this.page = page;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = page.ConnString();
                SqlConnection openConnection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();

                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = openConnection;
                adapter.SelectCommand.CommandText = "Delete from CENSUS_TRACT where TRACT_ID = '" + txtTractID + "';";


                openConnection.Open();
                adapter.Fill(dataset, "Census Tract");
                adapter.Dispose();
                dataset.Dispose();
                openConnection.Close();

                this.Hide();
                Delete delForm = new Delete(page);
                delForm.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete delForm = new Delete(page);
            delForm.Show();
        }
    }
}
