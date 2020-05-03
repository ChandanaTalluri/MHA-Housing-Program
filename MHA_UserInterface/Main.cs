using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHA_UserInterface
{
    public partial class Main : Form
    {
        WelcomPage frmLogin;

        public Main(WelcomPage objLogin)
        {
            InitializeComponent();
            this.frmLogin = objLogin;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search objSerach = new Search(frmLogin);
            objSerach.Show();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert objSerach = new Insert(frmLogin);
            objSerach.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update objSerach = new Update(frmLogin);
            objSerach.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete objSerach = new Delete(frmLogin);
            objSerach.Show();
        }
    }
}
