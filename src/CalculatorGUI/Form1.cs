using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        bool isChained, wasCalculated, wasError, comma = false;

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
                        return IVSMath.Add(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        comma = false;
                        wasError = true;
                        return double.NaN;
                    }
                case "-":
                    try {
                        return IVSMath.Substract(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        comma = false;
                        wasError = true;
                        return double.NaN;
                    }
                case "*":
                    try {
                        return IVSMath.Multiply(x, y);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                case "/":
                    try {
                        return IVSMath.Divide(x, y);
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (DivideByZeroException) {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }                  
                case "^":
                    try {
                        return IVSMath.Power(x, Convert.ToInt32(y));
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (DivideByZeroException) {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (ArithmeticException) {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                case "√":
                    try {
                        return IVSMath.Root(x, Convert.ToInt32(y));
                    }
                    catch (ArithmeticException) {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
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
                        comma = false;
                        return double.NaN;
                    }
                case "√𝑥":
                    try {
                        return IVSMath.Root(x, 2);
                    }
                    catch (ArithmeticException)
                    {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                case "!":
                    try { 
                    return IVSMath.Factorial((int)x);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (ArithmeticException)
                    {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                case "sin":
                    return IVSMath.Sine(x);
                case "cos":
                    return IVSMath.Cosine(x);
                case "tan":
                    try {
                        return IVSMath.Tangent(x);
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (ArithmeticException)
                    {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
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
                        comma = false;
                        return double.NaN;
                    }
                    catch (OverflowException)
                    {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
            }
            return 0;
        }

        private void btn_Nbr_Click(object sender, EventArgs e) {
            if (wasError || wasCalculated)
            {
                btn_Delete_Click(sender, e);
            }
            else if (tb_Out.Text.Length >= 19)
            {
                return;
            }
            else
            {
                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!comma)
                    {
                        tb_Out.Text += button.Text;
                        comma = true;
                    }
                }
                else
                {
                    tb_Out.Text += button.Text;
                }
            }

        }

        private void btn_Back_Click(object sender, EventArgs e) {
            string str = tb_Out.Text;

            if (wasError) {
                btn_Delete_Click(sender, e);
            } else if (str.Length > 1) {
                str = str.Substring(0, str.Length - 1);
                tb_Out.Text = str;
                if (!str.Contains('.')) {
                    comma = false;
                }
            }
            else {
                str = "";
                tb_Out.Text = str;
                if (!str.Contains('.')) {
                    comma = false;
                }
            }
        }

        private void btn_MultipleValuesOperation_Click(object sender, EventArgs e) {

            Button button = (Button)sender;
            operationPerfomed = button.Text;

            if (!isChained) {
                double result;
                if (tb_Out.Text == ".") {
                    tb_Out.Text = "0";
                }
                if (tb_Out.Text == "") {
                    tb_Out.Text = "No input given";
                    wasError = true;
                    return;
                }
                else if (parseDouble(out result, tb_Out.Text)) {
                    resultValue = result;
                    lb_Next.Text = tb_Out.Text + " " + operationPerfomed;
                    isChained = true;
                    comma = false;
                }
                else {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            }
            else {
                double result;
                if (tb_Out.Text == ".") {
                    tb_Out.Text = "0";
                }
                if (tb_Out.Text == "") {
                    lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                    return;
                } else {
                    if (parseDouble(out result, tb_Out.Text)) {
                        resultValue = Calculate(operationPerfomed, resultValue, result);
                        if (wasError) {
                            return;
                        }
                        lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                        if (resultValue % 1 == 0) {
                            comma = false;
                        }

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
                    if (resultValue % 1 == 0) {
                        comma = false;
                    }
                    if (wasError){
                        return;
                    }
                    isChained = false;
                    tb_Out.Text = resultValue.ToString();
                    if (resultValue % 1 == 0) {
                        comma = false;
                    }
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
                        if (tb_Out.Text == ".") {
                            tb_Out.Text = "0";
                        }
                        if (parseDouble(out result, tb_Out.Text)) {
                            lb_Next.Text = $"{tb_Out.Text}{operationPerfomed}";
                            resultValue = Calculate(operationPerfomed, result);
                            if (resultValue % 1 == 0) {
                                comma = false;
                            }
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
                    if (resultValue % 1 == 0) {
                        comma = false;
                    }
                    if (wasError) {
                        return;
                    }
                    tb_Out.Text = resultValue.ToString();

                    isChained = false;
                    wasCalculated = true;
                    comma = false;

                    lb_Next.Text = "";
                    operationPerfomed = "";
                }
                else {
                    wasError = true;
                    return;
                }
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(CalcForm_Load);
        }

        private void CalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("dokumentace.pdf");
                Process.Start(startInfo);
            }
            if (e.KeyCode.ToString() == "F2")
            {
                About about = new About();
                about.ShowDialog();
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
            comma = false;
            tb_Out.Clear();
            lb_Next.Text = "";
        }
    }
}
