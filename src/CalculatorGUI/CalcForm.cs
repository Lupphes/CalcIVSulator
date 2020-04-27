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
using System.Globalization;

namespace CalculatorGUI
{
    /// <summary>
    /// "CalcForm" derives from Form structure
    /// </summary>
    public partial class CalcForm : Form {
        /// <summary>
        /// "CalcForm" component (main) in GUI calculator
        /// </summary>
        public CalcForm() {
            InitializeComponent();
        }

        double resultValue; // Value currently in buffer
        string operationPerfomed = ""; // Operation currently in buffer
        bool isChained, wasCalculated, wasError, comma = false; // Flags for states
        string documatationLocation = "dokumentace.pdf"; // Where is stored documentation
        NumberStyles styles = NumberStyles.Any; // Set number styles
        CultureInfo culture = CultureInfo.CreateSpecificCulture("cs-CZ"); // Set number culture

        /// <summary>Parses the text to a number
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        /// <returns>Returns bool if conversion was successful.</returns>
        private bool parseDouble(out double result, string number)
        {
            CultureInfo.DefaultThreadCurrentCulture = culture; // Define number culture
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            if (Double.TryParse(number, styles, culture, out result)) // Tries to parse the number
                return true;
            return false;
        }

        /// <summary>Calculates operations
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        /// <returns>Returns calculated double number.</returns>
        private double Calculate(string operation, double x, double y = 0) {
            switch (operation) { // Decides what operation should be performed and If there is an error then its error string
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
                        return IVSMath.Subtract(x, y);
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
                case "ⁿ√𝑥":
                    try {
                        return IVSMath.Root(y, Convert.ToInt32(x));
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
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
                    catch (ArithmeticException) {
                        tb_Out.Text = "Nepovolená operace";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                case "²√":
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
                    try {
                        return IVSMath.Sine(x);
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
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
                case "cos":
                    try {
                        return IVSMath.Cosine(x);
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
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
                case "tan":
                    try {
                        return IVSMath.Tangent(x);
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
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
                case "1/𝑥":
                    try {
                        return IVSMath.Power(x, -1);
                    }
                    catch (DivideByZeroException) {
                        tb_Out.Text = "Dělení nulou";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
                    catch (OverflowException) {
                        tb_Out.Text = "Overflow chyba";
                        wasError = true;
                        comma = false;
                        return double.NaN;
                    }
            }
            return 0;
        }

        /// <summary>Sets number or dot to text input
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_Nbr_Click(object sender, EventArgs e) {
            if (wasError || wasCalculated && !wasCalculated) {
                btn_Delete_Click(sender, e); // Sets calculator to initial state
            }
            else if (tb_Out.Text.Length >= 19) { // Max lenght of number
                return; 
            }
            else {
                Button button = (Button)sender;
                if (button.Text == ",") {
                    if (!comma) {
                        tb_Out.Text += button.Text;
                        comma = true;
                    }
                }
                else {
                    tb_Out.Text += button.Text;
                }
            }

        }

        /// <summary>Deletes one character from text input
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_Back_Click(object sender, EventArgs e) {
            string str = tb_Out.Text;

            if (wasError) { // Error state
                btn_Delete_Click(sender, e);
            } else if (str.Length > 1) { // Is able to go back
                str = str.Substring(0, str.Length - 1);
                tb_Out.Text = str;
                if (!str.Contains('.')) { comma = false; }
            }
            else {
                str = "";
                if (!str.Contains('.')) { comma = false; }
                tb_Out.Text = str;
            }
        }

        /// <summary>Calculates operations with multiple values
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_MultipleValuesOperation_Click(object sender, EventArgs e) {

            Button button = (Button)sender;
            
            if (tb_Out.Text == ",") { tb_Out.Text = "0"; } // Just dot -> change it on zero
            if (!isChained) {
                operationPerfomed = button.Text;
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
                    comma = false;
                }
                else { // Parse error
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            }
            else { 
                if (tb_Out.Text == "") {
                    lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                    return;
                } else {
                    double result;
                    if (parseDouble(out result, tb_Out.Text)) {
                        resultValue = Calculate(operationPerfomed, resultValue, result);
                        operationPerfomed = button.Text;
                        if (resultValue % 1 == 0) { comma = false; } else { comma = true; }
                        if (wasError) { return; }
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
            tb_Out.Text = "";
        }

        /// <summary>Calculates operations with just one value
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_SingleValueOperation_Click(object sender, EventArgs e) {
            Button button = (Button)sender;

            if (!wasError) { // If error state
                if (isChained) { // Previous operation is in buffer
                    if (tb_Out.Text == "")
                    {
                        lb_Next.Text = resultValue.ToString() + " " + operationPerfomed;
                        return;
                    }
                    else {
                        resultValue = Calculate(operationPerfomed, resultValue);
                        operationPerfomed = button.Text;
                        resultValue = Calculate(operationPerfomed, resultValue);
                        if (resultValue % 1 == 0) { comma = false; } else { comma = true; }
                        if (wasError) { return; }
                        tb_Out.Text = resultValue.ToString();
                        operationPerfomed = "";
                        wasCalculated = true;
                        isChained = false;
                        lb_Next.Text = "";
                    }
                }
                else { // No input
                    if (tb_Out.Text == "") {
                        tb_Out.Text = "No input given";
                        wasError = true;
                        return;
                    }
                    else {
                        double result;
                        if (tb_Out.Text == ",") { tb_Out.Text = "0"; }
                        if (parseDouble(out result, tb_Out.Text)) {
                            operationPerfomed = button.Text;
                            lb_Next.Text = $"{tb_Out.Text} {operationPerfomed}";
                            resultValue = Calculate(operationPerfomed, result);
                            if (resultValue % 1 == 0) { comma = false; } else { comma = true; }
                            if (wasError) { return; }
                            tb_Out.Text = resultValue.ToString();
                        }
                        else { // Parse error
                            tb_Out.Text = "Wrong input";
                            wasError = true;
                            return;
                        }
                    }
                }
            } else { // No input
                tb_Out.Text = "No input given";
                wasError = true;
                return;
            }
        }

        /// <summary>Resturn result to the text input and reset the calculator
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_Res_Click(object sender, EventArgs e) {
            if (tb_Out.Text == "") { // If the input is empty
                tb_Out.Text = resultValue.ToString();
                if (resultValue % 1 == 0) { comma = false; } else { comma = true; }
                isChained = false;

                lb_Next.Text = "";
                operationPerfomed = "";
            } else {
                double result;
                if (parseDouble(out result, tb_Out.Text)) { // Parse successful -> calculate value
                    resultValue = Calculate(operationPerfomed, resultValue, result); 
                    
                    if (wasError) { return; }
                    tb_Out.Text = resultValue.ToString();

                    isChained = false;
                    wasCalculated = true;
                    if (resultValue % 1 == 0) { comma = false; } else { comma = true; }
                    lb_Next.Text = "";
                    operationPerfomed = "";
                }
                else { // Parse error
                    wasError = true;
                    return;
                }
            }
        }

        /// <summary>Starts monitoring keys
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void CalcForm_Load(object sender, EventArgs e) {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(CalcForm_Load);
        }

        /// <summary>If key is pressed this function will react. It can react just on "F1" or "F2"
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void CalcForm_KeyDown(object sender, KeyEventArgs e) {
        
            if (e.KeyCode.ToString() == "F1") {
                try { 
                ProcessStartInfo startInfo = new ProcessStartInfo(documatationLocation); // Opens this file
                Process.Start(startInfo);
                }
                catch
                {
                    MessageBox.Show("Sorry, but it appears that your file with documentation is deleted. Please include it in your folder with program or use our printed version.", "File opening error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyCode.ToString() == "F2") {
                About about = new About(); // Launches another form
                about.ShowDialog();
            }
        }

        /// <summary>Changes the value of number in input to negative value
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_Negative_Click(object sender, EventArgs e) {   
            if (tb_Out.Text != "") { // If input is not empty
                double result;
                if (parseDouble(out result, tb_Out.Text)) {
                    tb_Out.Text = (result * -1).ToString();
                } else {
                    tb_Out.Text = "Wrong input";
                    wasError = true;
                    return;
                }
            } else if (wasError) { // If error do nothing
                return;
            }
            else { // Write an error for no input
                tb_Out.Text = "No input given";
                wasError = true;
                return;
            }
        }

        /// <summary>This method resets the calculator to its initial value.
        ///    (<paramref name="object"/>,<paramref name="event"/>).</summary>
        /// <param name="object">Object sender</param>
        /// <param name="event">Event argument</param>
        private void btn_Delete_Click(object sender, EventArgs e) {
            /* Reset kalkulacky */
            operationPerfomed = "";
            isChained = wasCalculated = wasError = comma = false;
            lb_Next.Text = "";
            tb_Out.Text = "";
        }
    }
}
