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
            Busboy bb = new Busboy();
            List<string> status = new List<string>();
            status = bb.RefreshTableStatuses();
            // Due to scope, had to utilize this with a bunch of switch statements
            // Wish there was a more elegant way.
            switch (status[0])
            {
                case "Red":
                    btnTableOne.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableOne.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableOne.BackColor = Color.Yellow;
                    break;
            }
            switch (status[1])
            {
                case "Red":
                    btnTableTwo.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableTwo.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableTwo.BackColor = Color.Yellow;
                    break;
            }
            switch (status[2])
            {
                case "Red":
                    btnTableThree.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableThree.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableThree.BackColor = Color.Yellow;
                    break;
            }
            switch (status[3])
            {
                case "Red":
                    btnTableFour.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableFour.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableFour.BackColor = Color.Yellow;
                    break;
            }
            switch (status[4])
            {
                case "Red":
                    btnTableFive.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableFive.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableFive.BackColor = Color.Yellow;
                    break;
            }
            switch (status[5])
            {
                case "Red":
                    btnTableSix.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableSix.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableSix.BackColor = Color.Yellow;
                    break;
            }
            switch (status[6])
            {
                case "Red":
                    btnTableSeven.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTableSeven.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTableSeven.BackColor = Color.Yellow;
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.LogOut();
        }
    }
}
