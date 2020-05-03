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
    public partial class Delete : Form
    {
        WelcomPage frmLogin;
        public Delete(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main objMain = new Main(frmLogin);
            objMain.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
