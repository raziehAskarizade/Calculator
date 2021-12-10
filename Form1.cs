using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingNumbers
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;
        Boolean check = false;
        public Form1()
        {
            InitializeComponent();
            txtDisplay_TextChanged(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            x = 0;
            y = 0;
            op = "";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            //if (txtDisplay.Text.Contains(".") == true)
            //    btnPoint.Enabled = false;
            //else
            //    btnPoint.Enabled = true;
            btnPoint.Enabled = !txtDisplay.Text.Contains(".");
            btnBackspace.Enabled = txtDisplay.Text.Length == 0 ? false : true;
            btnClear.Enabled = txtDisplay.Text.Length != 0 ? true : false;
            btnCE.Enabled = txtDisplay.Text.Length != 0 ? true : false;
            //btnClear.Enabled = Convert.ToBoolean(txtDisplay.Text.Length);
        }

        private void btnBackspace_MouseClick(object sender, MouseEventArgs e)
        {
            int length = int.Parse(txtDisplay.Text.Length.ToString());
            txtDisplay.Text = txtDisplay.Text.Substring(0, length - 1);
            //txtDisplay.Text = txtDisplay.Text.Remove(length - 1, 1);
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (panel1.Enabled == true)
            {
                btnOnOff.Text = "Off";
                this.KeyPreview = true;
                txtDisplay.Visible = true;
            }
            else
            {
                btnOnOff.Text = "On";
                this.KeyPreview = false;
                txtDisplay.Visible = false;
            }
            }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            foreach (Button x in panel1.Controls)
                if (x.Text == e.KeyChar.ToString())
                {
                    x.Focus();
                    x.ForeColor = Color.DarkRed;

                }
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || (e.KeyChar == '.' && !txtDisplay.Text.Contains(".")))
                numbers(temp, null);
            else if (e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '-' || e.KeyChar == '+')
                Operators(temp, null);
            else if (e.KeyChar == '=' || e.KeyChar == '\n')
                btnEqual_MouseClick(null, null);
            else if (e.KeyChar == 8 && txtDisplay.Text != "")
                btnBackspace_MouseClick(null, null);
        }

        private void btnEqual_MouseClick(object sender, MouseEventArgs e)
        {
            y = double.Parse(txtDisplay.Text);
            switch (op)
            {
                case ("*"):
                    z = x * y;
                    break;
                case ("+"):
                    z = x + y;
                    break;
                case ("-"):
                    z = x - y;
                    break;
                case ("/"):
                    z = x / y * 1.000;
                    break;

            }
            txtDisplay.Text = z.ToString();
            op = null;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Button x in panel1.Controls)
            {
                x.ForeColor = Color.Black;
                if (e.KeyCode == Keys.Enter)
                {
                    btnEqual_MouseClick(null, null);
                    btnEqual.Focus();
                    btnEqual.ForeColor = Color.DarkRed;
                }
            }
        }

        private void btnNegetive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (0 - Math.Abs(double.Parse(txtDisplay.Text))).ToString();
        }

        private void numbers(object sender, MouseEventArgs e)
        {
            if (check == true)
            {
                txtDisplay.Text = "";
                check = false;
            }
            txtDisplay.Text += ((Button)sender).Text;
        }
        private void Operators(object sender, MouseEventArgs e)
        {
            if (op != null)
                btnEqual_MouseClick(null, null);
            x = double.Parse(txtDisplay.Text);
            op = ((Button)sender).Text;
            check = true;
        }
    }
}
