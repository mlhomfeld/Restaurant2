using System;
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
    public partial class ManagerAdd : Form
    {
        public ManagerAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Manager mng = new Manager();
            mng.CreateEmployee(txtFirstName.Text, txtLastName.Text, txtPayRate.Text, txtPass.Text, txtRole.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mng = new ManagerForm();
            mng.Show();
        }
    }
}
