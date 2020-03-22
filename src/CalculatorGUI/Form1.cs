using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }


        private void btn_Nbr_0_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "0";
        }

        private void btn_Nbr_1_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "1";
        }

        private void btn_Nbr_2_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "2";
        }

        private void btn_Nbr_3_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "3";
        }

        private void btn_Nbr_4_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "4";
        }

        private void btn_Nbr_5_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "5";
        }

        private void btn_Nbr_6_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "6";
        }

        private void btn_Nbr_7_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "7";
        }

        private void btn_Nbr_8_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "8";
        }

        private void btn_Nbr_9_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "9";
        }

        private void btn_Comma_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += ",";
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            rtb_Out.Text = "";
        }

        // -----------------------------------------------------

        private void btn_Add_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "+";
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "-";
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "*";
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "/";
        }

        private void btn_Root_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "sqrt(";
        }

        private void btn_Power_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "^";
        }

        private void btn_PowTo1_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "^-1";
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "sin(";
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "cos(";
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            rtb_Out.Text += "tan(";
        }
        private void btn_Res_Click(object sender, EventArgs e)
        {
            string input = rtb_Out.Text;
            rtb_Out.Text = "Calculating...";
        }

    }
}
