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
    public partial class Delete_Owner : Form
    {
        WelcomPage page;
        public Delete_Owner(WelcomPage page)
        {
            InitializeComponent();
            this.page = page;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete delForm = new Delete(page);
            delForm.Show();
        }
    }
}
