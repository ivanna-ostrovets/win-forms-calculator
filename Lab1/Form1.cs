using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        private string[] inputs = new string[0];
        private string[] operations = { "/", "x", "+", "-" };
        private double resultNumber = 0;
        private string lastOperation;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private double ParseDouble(string number)
        {
            double result;

            return Double.TryParse(number, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result) 
                ? result
                : 0;
        }

        private void PerformOperation(string operation, string operand)
        {
            switch (operation)
            {
                case "+":
                    resultNumber += ParseDouble(operand);
                    break;
                case "-":
                    resultNumber -= ParseDouble(operand);
                    break;
                case "/":
                    resultNumber /= ParseDouble(operand);
                    break;
                case "x":
                    resultNumber *= ParseDouble(operand);
                    break;
                default:
                    break;
            }
        }

        private void AddDigit(object sender, EventArgs e)
        {
            string text = (sender as Button).Text;

            if (inputs.Length == 2)
            {
                resultNumber = ParseDouble(inputs[0]);
            }

            if (operations.Any(operation => operation == text))
            {
                if (inputs.Length == 0)
                {
                    Array.Resize(ref inputs, inputs.Length + 1);
                    inputs[inputs.Length - 1] = "0";
                }

                if (operations.Any(operation => operation == inputs.Last()))
                {
                    inputs[inputs.Length - 1] = text;
                    this.expression.Text = $"{this.expression.Text.Remove(this.expression.Text.Length - 1)}{text}";
                    lastOperation = text;
                }
                else
                {
                    if (this.expression.Text.Length > 0 && this.expression.Text[this.expression.Text.Length - 1] == ')')
                    {
                        this.expression.Text += $" {text}";

                    } else
                    {
                        this.expression.Text += $" {inputs.Last()} {text}";
                    }

                    if (inputs.Length > 2)
                    {
                        PerformOperation(lastOperation, inputs.Last());
                        this.result.Text = resultNumber.ToString();
                    }

                    Array.Resize(ref inputs, inputs.Length + 1);
                    inputs[inputs.Length - 1] = text;

                    lastOperation = text;
                }
            }
            else
            {
                string enteredNumber;

                // TODO: case with rewriting last operation 
                if (
                    (inputs.Length > 0 && operations.Any(operation => operation == inputs.Last())) 
                    || (this.expression.Text.Length > 0 && this.expression.Text[this.expression.Text.Length - 1] == ')')
                    )
                {
                    enteredNumber = text;
                    Array.Resize(ref inputs, inputs.Length + 1);
                    inputs[inputs.Length - 1] = enteredNumber;
                } 
                else
                {
                    if (this.result.Text == "0")
                    {
                        enteredNumber = text;
                        Array.Resize(ref inputs, inputs.Length + 1);
                    } else {
                        enteredNumber = $"{this.result.Text}{text}";
                    }

                }

                this.result.Text = enteredNumber;
                inputs[inputs.Length - 1] = this.result.Text;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            this.result.Text = "0";
        }

        private void ClearAll(object sender, EventArgs e)
        {
            this.result.Text = "0";
            resultNumber = 0;
            Array.Resize(ref inputs, 0);
            this.expression.Text = "";
            lastOperation = "";
        }

        private void DeleteLast(object sender, EventArgs e)
        {
            this.result.Text = this.result.Text.Length == 1 ? "0" : this.result.Text.Remove(this.result.Text.Length - 1);
        }

        private void MakeNegative(object sender, EventArgs e)
        {
            if (this.result.Text[0] == '-')
            {
                this.result.Text = this.result.Text.Substring(1);
            } 
            else
            {
                this.result.Text = this.result.Text == "0" ? "0" : $"-{this.result.Text}";
            }

            inputs[inputs.Length - 1] = this.result.Text;
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (!operations.Any(operation => operation == inputs.Last()))
            {
                PerformOperation(lastOperation, inputs.Last());
            }

            this.result.Text = inputs.Length <= 2 ? inputs[0] : resultNumber.ToString();
            Array.Resize(ref inputs, 1);
            inputs[0] = this.result.Text;
            this.expression.Text = ""; 
            lastOperation = "";
        } 

        private void AddPoint(object sender, EventArgs e)
        {
            if (operations.Any(operation => operation == inputs.Last()))
            {
                if (inputs.Length == 2) 
                {
                    resultNumber = ParseDouble(inputs[0]);
                }

                this.result.Text = "0.";
                Array.Resize(ref inputs, inputs.Length + 1);
            }

            if (!this.result.Text.Contains("."))
            {
                this.result.Text = $"{this.result.Text}.";
            }
             
            inputs[inputs.Length - 1] = this.result.Text;
        }

        private void CalculateTrigonometric(object sender, EventArgs e)
        {
            string text = (sender as Button).Text;

            if (inputs.Length == 0)
            {
                Array.Resize(ref inputs, inputs.Length + 1);
            }

            switch(text)
            {
                case "sin":
                    resultNumber = Math.Sin(ParseDouble(this.result.Text));
                    break;
                case "cos":
                    resultNumber = Math.Cos(ParseDouble(this.result.Text));
                    break;
                case "tan":
                    resultNumber = Math.Tan(ParseDouble(this.result.Text));
                    break;

            }

            this.expression.Text += $" {text}({this.result.Text})";
            this.result.Text = resultNumber.ToString(new CultureInfo("en-US"));
            inputs[inputs.Length - 1] = resultNumber.ToString(new CultureInfo("en-US"));
        }
    
        private void ResetPythagoreanTheoremForm(object sender, EventArgs e)
        {
            this.avalue.ResetText();
            this.bvalue.ResetText();
            this.cvalue.ResetText();
        }

        private void CalculatePythagoreanTheorem(object sender, EventArgs e)
        {
            double a = ParseDouble(this.avalue.Text.Replace(',', '.').Replace(" ", ""));
            double b = ParseDouble(this.bvalue.Text.Replace(',', '.').Replace(" ", ""));
            double c = ParseDouble(this.cvalue.Text.Replace(',', '.').Replace(" ", ""));

            if (a != 0 && b != 0)
            {
                this.cvalue.Text = (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))).ToString();
            }

            if (a != 0 && c != 0)
            {
                this.bvalue.Text = (Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2))).ToString();
            }

            if (c != 0 && b != 0)
            {
                this.avalue.Text = (Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2))).ToString();
            }
        }

        private void CalculateRootsOfQuadraticEquation(object sender, EventArgs e)
        {
            double a = ParseDouble(this.aconst.Text.Replace(',', '.').Replace(" ", ""));
            double b = ParseDouble(this.bconst.Text.Replace(',', '.').Replace(" ", ""));
            double c = ParseDouble(this.cconst.Text.Replace(',', '.').Replace(" ", ""));

            if (a == 0)
            {
                a = 1;
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0)
            {
                this.firstRoot.Visible = false;
                this.secondRoot.Visible = false;
                this.firstRootLabel.Visible = false;
                this.secondRootLabel.Visible = false;
                this.noRootsLabel.Visible = true;

                return;
            }

            this.noRootsLabel.Visible = false;
            this.firstRootLabel.Visible = true;
            this.secondRootLabel.Visible = true;
            this.firstRoot.Visible = true;
            this.secondRoot.Visible = true;

            this.firstRoot.Text = ((-b - Math.Sqrt(discriminant)) / (2 * a)).ToString();
            this.secondRoot.Text = ((-b + Math.Sqrt(discriminant)) / (2 * a)).ToString();
        }

        private void ResetQuadraticEquationForm(object sender, EventArgs e)
        {
            this.aconst.ResetText();
            this.bconst.ResetText();
            this.cconst.ResetText();
            this.firstRoot.ResetText();
            this.secondRoot.ResetText();
            this.firstRoot.Visible = true;
            this.secondRoot.Visible = true;
            this.firstRootLabel.Visible = true;
            this.secondRootLabel.Visible = true;
            this.noRootsLabel.Visible = false;
        }
    }
}
