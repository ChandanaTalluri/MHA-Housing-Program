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
    public partial class Search : Form
    {

        WelcomPage frmLogin;
        public Search(WelcomPage objLogin)
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
            Main objMain = new Main(frmLogin);
            objMain.Show();
        }
    }
}
