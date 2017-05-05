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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            ManagerAdd addFrm = new ManagerAdd();
            addFrm.Show();
            this.Hide();
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ManagerModify modifyFrm = new ManagerModify();
            modifyFrm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.LogOut();
        }

        private void txtRmvEmployee_TextChanged(object sender, EventArgs e)
        {
            Manager man = new Manager();
            man.RemoveEmployee(txtRmvEmployee.Text);
        }
    }
}
