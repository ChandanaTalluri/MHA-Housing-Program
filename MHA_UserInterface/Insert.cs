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

    public partial class Insert : Form
    {
        WelcomPage frmLogin;
        public Insert(WelcomPage objLogin)
        {

            InitializeComponent();
            this.frmLogin = objLogin;
        }
        private void ins_Bulding_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertBuilding objInsertBuilding = new InsertBuilding(frmLogin);
            objInsertBuilding.Show();
        }

        private void ins_CensusTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_CensusTrack obj_Insert_Tract = new Insert_CensusTrack(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void btn_insMortgager_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertMortgager obj_Insert_Tract = new InsertMortgager(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ins_owner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Owner obj_Insert_Tract = new Insert_Owner(frmLogin);
            obj_Insert_Tract.Show();
        }

        private void btn_Unit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Unit obj_Insert_Tract = new Insert_Unit(frmLogin);
            obj_Insert_Tract.Show();
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
