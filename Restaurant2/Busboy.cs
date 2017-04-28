using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant2
{
    public class Busboy : Employee
    {
        public void Clean()
        {
            MessageBox.Show("I'm clean!");
        }

    }
}