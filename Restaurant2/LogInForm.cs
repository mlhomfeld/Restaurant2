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

    public partial class LogInForm : Form
    {

        public int employeeID;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.LogIn(Convert.ToInt32(txtID.Text), txtPass.Text);

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
