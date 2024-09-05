using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string calTotal;
        string operation;
        int num1;
        int num2;
        int result;

        public Form1()
        {
            InitializeComponent();
            lbDisplay.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (mainTb.Text == "0")
            { mainTb.Text = ""; }

            mainTb.Text += btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(mainTb.Text);

            mainTb.Text = "0";
            lbDisplay.Text = num1 + " + ";
            lbDisplay.Visible = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(mainTb.Text);

            mainTb.Text = "0";
            lbDisplay.Text = num1 + " - ";
            lbDisplay.Visible = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(mainTb.Text);

            mainTb.Text = "0";
            lbDisplay.Text = num1 + " x ";
            lbDisplay.Visible = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(mainTb.Text);

            mainTb.Text = "0";
            lbDisplay.Text = num1 + " / ";
            lbDisplay.Visible = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(mainTb.Text);

            if (operation == "+")
            { 
                result = num1 + num2;
            }
            else if (operation == "-")
            { result = num1 - num2; }
            else if (operation == "*")
            { result = num1 * num2; }
            else if (operation == "-")
            { result = num1 / num2; }

            mainTb.Text = result.ToString();
            lbDisplay.Text = lbDisplay.Text + "" + num2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mainTb.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            lbDisplay.Text = "";
            lbDisplay.Visible=false;
        }

        private void mainTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
