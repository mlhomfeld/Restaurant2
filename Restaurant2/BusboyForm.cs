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
    }
}
