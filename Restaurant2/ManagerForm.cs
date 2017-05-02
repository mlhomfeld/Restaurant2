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
            ManagerInfoForm managerinfoFrm = new ManagerInfoForm();
            managerinfoFrm.Show();
            this.Hide();
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ManagerInfoForm managerinfoFrm = new ManagerInfoForm();
            managerinfoFrm.Show();
            this.Hide();
        }
    }
}
