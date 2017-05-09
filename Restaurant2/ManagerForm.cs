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
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Need to add a small listbox on manager window that shows some employee info to choose from instead of the current type id into text box
            //  If i added this i could get rid of the multiple forms i used and just call on one anytime a form is neccesary
            Manager man = new Manager();
            man.RemoveEmployee(txtRmvEmployee.Text);
        }

        private void btnCheckInventory_Click(object sender, EventArgs e)
        {
            
        }
    }
}
