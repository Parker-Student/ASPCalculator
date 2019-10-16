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
        double total = 0;
        string operation = "";
        bool opPref = false;
        //string result = "";

        public frmCalc()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {

            if ((lblDisplay.Text == "0") || (opPref))
            {
                lblDisplay.Text = String.Empty;
            };
            opPref = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!lblDisplay.Text.Contains("."))
                    lblDisplay.Text = lblDisplay.Text + button.Text;

            }
            else
                lblDisplay.Text = lblDisplay.Text + button.Text;
            
        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            total = Double.Parse(lblDisplay.Text);
            opPref = true;
            // lblDisplay.Text = total + " " + opPref;
        }

        private void equals_clicked(object sender, EventArgs e)
        {
           
            switch (operation)
            {
                case "+":
                    lblDisplay.Text = (total + Double.Parse(lblDisplay.Text)).ToString();
                    break;
                case "/":
                    lblDisplay.Text = (total / Double.Parse(lblDisplay.Text)).ToString();
                    break;
                case "x":
                    lblDisplay.Text = (total * Double.Parse(lblDisplay.Text)).ToString();
                    break;
                case "-":
                    lblDisplay.Text = (total - Double.Parse(lblDisplay.Text)).ToString();
                    break;
               // case "sqrt":
                 //   lblDisplay.Text = (Math.Sqrt(Double.Parse(lblDisplay.Text))).ToString();
                   // break;
                default:
                    break;
            }

        }

        private void clear_clicked(object sender, EventArgs e)
        {
            total = 0;
            operation = "";
            opPref = false;
            lblDisplay.Text = "0";

        }

        private void back_clicked(object sender, EventArgs e)
        {
            //lblDisplay.Text = lblDisplay.ToString().TrimEnd(lblDisplay.Text[lblDisplay.Text.Length - 1]);

            if (lblDisplay.Text != "")
            {
               lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
    }

        private void sqrt_clicked(object sender, EventArgs e)
        {
            lblDisplay.Text = (Math.Sqrt(Double.Parse(lblDisplay.Text))).ToString();
            total = 0;
            operation = "";
            opPref = false;
        }

        private void frac_clicked(object sender, EventArgs e)
        {
            lblDisplay.Text = (1/(Double.Parse(lblDisplay.Text))).ToString();
            total = 0;
            operation = "";
            opPref = false;
        }

        private void posneg_click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.StartsWith("-"))
            {
                lblDisplay.Text = lblDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(lblDisplay.Text) && decimal.Parse(lblDisplay.Text) != 0)
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
            }
        }
    }
}



