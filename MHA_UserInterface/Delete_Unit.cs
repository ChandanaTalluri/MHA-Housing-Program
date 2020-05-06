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
    public partial class Delete_Unit : Form
    {
        WelcomPage page;
        public Delete_Unit(WelcomPage page)
        {
            InitializeComponent();
            this.page = page;
        }

        private void Delete_Unit_Load(object sender, EventArgs e)
        {

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
                adapter.SelectCommand.CommandText = "Delete from UNIT where UNIT_ID = '" + txtUnitID.Text + "';";


                openConnection.Open();
                adapter.Fill(dataset, "Unit");
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
