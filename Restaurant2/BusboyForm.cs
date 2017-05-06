using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;


namespace Restaurant2
{
    public partial class BusboyForm : Form 
    {
        public BusboyForm()
        {
            InitializeComponent();
        }
        Busboy busboy = new Busboy();
        //Buttons below just execute the code called from the Busboy class
        private void btnTable1_Click(object sender, EventArgs e)
        {
            busboy.Open(1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            busboy.Open(2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            busboy.Open(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            busboy.Open(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            busboy.Open(5);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            busboy.Open(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            busboy.Open(7);
        }

        private void btnBusboyRefresh_Click(object sender, EventArgs e)
        {
            Busboy bb = new Busboy();
            List<string> status = new List<string>();
            status = bb.RefreshTableStatuses();
            // Due to scope, had to utilize this with a bunch of switch statements
            // Wish there was a more elegant way.
            switch (status[0])
            {
                case "Red":
                    btnTable1.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable1.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable1.BackColor = Color.Yellow;
                    break;
            }
            switch (status[1])
            {
                case "Red":
                    btnTable2.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable2.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable2.BackColor = Color.Yellow;
                    break;
            }
            switch (status[2])
            {
                case "Red":
                    btnTable3.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable3.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable3.BackColor = Color.Yellow;
                    break;
            }
            switch (status[3])
            {
                case "Red":
                    btnTable4.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable4.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable4.BackColor = Color.Yellow;
                    break;
            }
            switch (status[4])
            {
                case "Red":
                    btnTable5.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable5.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable5.BackColor = Color.Yellow;
                    break;
            }
            switch (status[5])
            {
                case "Red":
                    btnTable6.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable6.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable6.BackColor = Color.Yellow;
                    break;
            }
            switch (status[6])
            {
                case "Red":
                    btnTable7.BackColor = Color.Red;
                    break;
                case "Green":
                    btnTable7.BackColor = Color.LightGreen;
                    break;
                case "Yellow":
                    btnTable7.BackColor = Color.Yellow;
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Employee emp = new Restaurant2.Employee();
            emp.LogOut();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Employee emp = new Employee();
        //    emp.Timestamp(3, "Clean Table");

        //}

    }
}
