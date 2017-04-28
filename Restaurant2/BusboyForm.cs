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
    public partial class BusboyForm : Form
    {
        public BusboyForm()
        {
            InitializeComponent();
        }

        private void btnTheButton_Click(object sender, EventArgs e)
        {
            Busboy bus = new Busboy();
            bus.Clean();
        }
    }
}
