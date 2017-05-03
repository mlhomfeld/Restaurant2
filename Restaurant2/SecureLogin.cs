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
    public partial class SecureLogin : Form
    {
        public SecureLogin()
        {
            InitializeComponent();
        }

        // SecureLogin will require the manager to input the random number he has been 
        // challenged with in order to continue. The thunderdome button will create a new
        // employee object and run the manager response method.
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ManagerResponse(Convert.ToInt32(txtResponse.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
