using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IVSMathLibrary;

namespace CalculatorGUI
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        double resultValue;
        string operationPerfomed = "";
        bool isChained = false;
        bool calculated = false;
        bool wasError = false;


        private void btn_Nbr_Click(object sender, EventArgs e)
        {
            if (tb_Out.Text == "0" || wasError || calculated)
            {
                tb_Out.Clear();
                wasError = false;
                calculated = false;
            }

            Button button = (Button)sender;
            tb_Out.Text += button.Text;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            string s = tb_Out.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            tb_Out.Text = s;

        }

        private void btn_BO_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operationPerfomed = button.Text;

            if (isChained)
            {
                
                double buffer;
                if (tb_Out.Text == "")
                {
                    lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                    return;
                }
                else
                {
                    if (parseDouble(out buffer, tb_Out.Text))
                    {
                        resultValue = Calculate(operationPerfomed, resultValue, buffer);
                        lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;

                    } else
                    {
                        tb_Out.Text = "Wrong input";
                        wasError = true;
                        isChained = false;
                        return;
                    }
                }
            }
            else
            {
                double result;
                if (tb_Out.Text == "")
                {
                    tb_Out.Text = "No input given";
                    wasError = true;
                    return;
                }
                else if (parseDouble(out result, tb_Out.Text))
                {
                    resultValue = result;
                    lb_Next.Text = tb_Out.Text + " " + operationPerfomed;
                    isChained = true;
                }
                else
                {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }

            }
            tb_Out.Clear();

        }

        private void btn_SO_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerfomed = button.Text;

            resultValue = Calculate(operationPerfomed, resultValue);
            isChained = false;
            tb_Out.Text = resultValue.ToString();
            operationPerfomed = "";
            calculated = true;
            lb_Next.Text = "";
        }

        private void btn_Res_Click(object sender, EventArgs e)
        {
            if (tb_Out.Text == "")
            {
                tb_Out.Text = resultValue.ToString();
                isChained = false;
                lb_Next.Text = "";
                operationPerfomed = "";
                calculated = true;
            } else
            {
                double result;
                if (parseDouble(out result, tb_Out.Text))
                {
                    resultValue = Calculate(operationPerfomed, resultValue, result);
                    tb_Out.Text = resultValue.ToString();

                    isChained = false;
                    calculated = true;

                    lb_Next.Text = "";
                    operationPerfomed = "";
                }
                else
                {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            }
        }

        private bool parseDouble(out double result, string number)
        {
            if (Double.TryParse(number, out result))
                return true;
            return false;
        }

        private void errorSkipper(object sender, EventArgs e)
        {
            if (wasError)
            {
                tb_Out.Clear();
                lb_Next.Text = "";
            }
        }

        private double Calculate(string operation, double x, double y = 0)
        {
            switch (operation)
            {
                case "+":
                    return x + y; // IVSMath.Add(x, y);
                case "-":
                    return x - y; // IVSMath.Substract(x, y);
                case "*":
                    return x * y; // IVSMath.Multiply(x, y);
                case "/":
                    return x / y; // IVSMath.Divide(x, y);
                case "^":
                    return IVSMath.Power(x, Convert.ToInt32(y));
                case "√":
                    return IVSMath.Root(x, Convert.ToInt32(y));
                case "1/𝑥":
                    return IVSMath.Power(x, -1);
                case "sin":
                    return 8; // IVSMath.Sine(x);
                case "cos":
                    return IVSMath.Cosine(x);
                case "tan":
                    return IVSMath.Tangent(x);
            }
            return 0;
        }
                        
    }
}
