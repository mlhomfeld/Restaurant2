﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class ManagerModify : Form
    {
        public ManagerModify()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Manager man = new Manager();
            man.ModifyEmployee(txtEmployeeID.Text, txtFirstName.Text, txtLastName.Text, txtPayRate.Text, txtPass.Text, txtRole.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mng = new ManagerForm();
            mng.Show();
        }
    }
}
