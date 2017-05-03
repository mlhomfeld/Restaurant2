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
            // Creates a new employee object and runs the Login method, passing along the
            // employee's ID and password. The password field is obscured and only * are shown
            Employee emp = new Employee();
            emp.LogIn(Convert.ToInt32(txtID.Text), txtPass.PasswordChar.ToString());

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
