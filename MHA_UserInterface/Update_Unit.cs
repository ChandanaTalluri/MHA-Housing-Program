﻿using System;
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
    public partial class Update_Unit : Form
    {
        private WelcomPage loginForm;

        public Update_Unit(WelcomPage newLoginForm)
        {
            this.loginForm = newLoginForm;
        }

        private bool updateWithSQL(string updateStatement)
        {

        }

        private bool primaryKeyExists(string key)
        {

        }

        private void Update_Unit_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (primaryKeyExists(txt_UnitID.Text))
            {

            }
            else
            {
                MessageBox.Show("The primary key provided does not exist.", "Error");
            }
        }
    }
}
