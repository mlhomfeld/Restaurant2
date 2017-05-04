using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class WaiterForm : Form
    {
        public WaiterForm()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTableOne_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(1);
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(2);
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(3);
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(4);
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(5);
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(6);
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.SetTableToDirty(7);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Employee bb = new Employee();
            bb.RefreshTableStatuses();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.LogOut();
        }
    }
}
