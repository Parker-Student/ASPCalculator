using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF.Calculator
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lblDisplay.Text = lblDisplay.Text + button.Text;

        }

    }
}



