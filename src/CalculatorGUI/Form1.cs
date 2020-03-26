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
        public CalcForm() {
            InitializeComponent();
        }

        double resultValue;
        string operationPerfomed = "";
        bool isChained, wasCalculated, wasError = false;

        private bool parseDouble(out double result, string number)
        {
            if (Double.TryParse(number, out result))
                return true;
            return false;
        }

        private double Calculate(string operation, double x, double y = 0)
        {
            switch (operation)
            {
                case "+":
                    try {
                        return x + y; // IVSMath.Add(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                case "-":
                    try {
                        return x - y; // IVSMath.Substract(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                case "*":
                    try {
                        return x * y; // IVSMath.Multiply(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                case "/":
                    try {
                        return IVSMath.Divide(x, y);
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                    catch (DivideByZeroException) {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        return double.NaN;
                    }                  
                case "^":
                    try {
                        return IVSMath.Power(x, Convert.ToInt32(y));
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                    catch (DivideByZeroException) {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        return double.NaN;
                    }
                    catch (Exception) {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        return double.NaN;
                    }
                case "√":
                    try {
                        return IVSMath.Root(x, Convert.ToInt32(y));
                    }
                    catch (Exception) {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        return double.NaN;
                    }
                case "𝑥^2":
                    try {
                        return IVSMath.Power(x, 2);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        return double.NaN;
                    }
                case "√𝑥":
                    try {
                        return IVSMath.Root(x, 2);
                    }
                    catch (Exception)
                    {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        return double.NaN;
                    }
                case "!":
                    return IVSMath.Factorial(Convert.ToInt32(x));
                case "sin":
                    return 8; // IVSMath.Sine(x);
                case "cos":
                    return IVSMath.Cosine(x);
                case "tan":
                    try {
                        return IVSMath.Tangent(x);
                    }
                    catch (Exception)
                    {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        return double.NaN;
                    }
                case "1/𝑥":
                    try {
                        return IVSMath.Power(x, -1);
                    }
                    catch (DivideByZeroException)
                    {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        return double.NaN;
                    }
            }
            return 0;
        }

        private void btn_Nbr_Click(object sender, EventArgs e) {
            if (tb_Out.Text == "0" || wasError || wasCalculated) {
                tb_Out.Clear();
                wasError = false;
                wasCalculated = false;
            }
            Button button = (Button)sender;
            tb_Out.Text += button.Text;
        }

        private void btn_Back_Click(object sender, EventArgs e) {
            string str = tb_Out.Text;

            if (wasError) {
                btn_Delete_Click(sender, e);
            } else if (str.Length > 1) {
                str = str.Substring(0, str.Length - 1);
            }
            else {
                str = "";
            }
            tb_Out.Text = str;
        }

        private void btn_MultipleValuesOperation_Click(object sender, EventArgs e) {

            Button button = (Button)sender;
            operationPerfomed = button.Text;

            if (!isChained) {
                double result;

                if (tb_Out.Text == "") {
                    tb_Out.Text = "No input given";
                    wasError = true;
                    return;
                }
                else if (parseDouble(out result, tb_Out.Text)) {
                    resultValue = result;
                    lb_Next.Text = tb_Out.Text + " " + operationPerfomed;
                    isChained = true;
                }
                else {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            }
            else {
                double result;
                if (tb_Out.Text == "") {
                    lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                    return;
                }
                else {
                    if (parseDouble(out result, tb_Out.Text)) {
                        resultValue = Calculate(operationPerfomed, resultValue, result);
                        if (wasError) {
                            return;
                        }
                        lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;

                    }
                    else {
                        tb_Out.Text = "Wrong input";
                        wasError = true;
                        isChained = false;
                        return;
                    }
                }
            }
            tb_Out.Clear();
        }

        private void btn_SingleValueOperation_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            operationPerfomed = button.Text;

            if (!wasError) {
                if (isChained)
                {
                    resultValue = Calculate(operationPerfomed, resultValue);
                    if (wasError){
                        return;
                    }
                    isChained = false;
                    tb_Out.Text = resultValue.ToString();
                    operationPerfomed = "";
                    wasCalculated = true;
                    lb_Next.Text = "";
                }
                else {
                    double result;
                    if (tb_Out.Text == "") {
                        tb_Out.Text = "No input given";
                        wasError = true;
                        return;
                    }
                    else {
                        if (parseDouble(out result, tb_Out.Text)) {
                            resultValue = Calculate(operationPerfomed, resultValue, result);
                            if (wasError) {
                                return;
                            }
                            tb_Out.Text = resultValue.ToString();

                        }
                        else {
                            tb_Out.Text = "Wrong input";
                            wasError = true;
                            return;
                        }
                    }
                }
            } else {
                tb_Out.Text = "No input given";
                wasError = true;
                return;
            }
        }

        private void btn_Res_Click(object sender, EventArgs e) {
            if (tb_Out.Text == "") {
                tb_Out.Text = resultValue.ToString();
                isChained = false;
                lb_Next.Text = "";
                operationPerfomed = "";
            } else {
                double result;
                if (parseDouble(out result, tb_Out.Text)) {
                    resultValue = Calculate(operationPerfomed, resultValue, result);
                    if (wasError) {
                        return;
                    }
                    tb_Out.Text = resultValue.ToString();

                    isChained = false;
                    wasCalculated = true;

                    lb_Next.Text = "";
                    operationPerfomed = "";
                }
                else {
                    wasError = true;
                    return;
                }
            }
        }

        private void btn_Negative_Click(object sender, EventArgs e) {
            double result;
            if (tb_Out.Text != "") { 
                if (parseDouble(out result, tb_Out.Text)) {
                    tb_Out.Text = (result * -1).ToString();
                } else {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            } else if (wasError) {
                return;
            }
            else {
                tb_Out.Text = "No input given";
                wasError = true;
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            operationPerfomed = "";
            isChained = false;
            wasCalculated = false;
            wasError = false;
            tb_Out.Clear();
            lb_Next.Text = "";

        }
    }
}
