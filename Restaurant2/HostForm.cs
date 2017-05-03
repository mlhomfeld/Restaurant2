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
namespace Restaurant2
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        private void btnCreateParty_Click(object sender, EventArgs e)
        {

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(1);

        }
        private void btnTable2_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(2);

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(5);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            Host hst = new Host();
            hst.SetTableToOccupied(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
