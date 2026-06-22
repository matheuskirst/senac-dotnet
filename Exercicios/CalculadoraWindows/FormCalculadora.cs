namespace CalculadoraWindows
{
    public partial class FormCalculadora : Form
    {
        public Calculadora calculator = new Calculadora();
        public FormCalculadora()
        {
            InitializeComponent();
            entryBox.Text = "0";
            this.KeyPreview = true;
        }

        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                calculator.AddDigit(e.KeyChar.ToString());

                entryBox.AppendText(e.KeyChar.ToString());
            }
        }

        private void FormCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add: addButton_Click(sender, e); break;

                case Keys.Subtract: subtractButton_Click(sender, e); break;

                case Keys.Multiply: multiplyButton_Click(sender, e); break;

                case Keys.Divide: divideButton_Click(sender, e); break;

                case Keys.Enter: equalsButton_Click(sender, e); break;
                case Keys.Oemplus:
                    if (e.Shift)
                    {
                        addButton_Click(sender, e);
                    }
                    else
                    {
                        equalsButton_Click(sender, e);
                    }
                    break;

                case Keys.Delete: clearAllButton_Click(sender, e); break;

                //case Keys.Back: deleteButton_Click(sender, e); break;
            }
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("1");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("2");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("3");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("4");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("5");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("6");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("7");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberEightButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("8");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("9");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("0");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit(",");

            entryBox.Text = calculator.currentInput;
            this.ActiveControl = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("+");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" + ");
            entryBox.Text = calculator.resultValue.ToString();
            this.ActiveControl = null;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("-");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" - ");
            entryBox.Text = calculator.resultValue.ToString();
            this.ActiveControl = null;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("*");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" x ");
            entryBox.Text = calculator.resultValue.ToString();
            this.ActiveControl = null;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("/");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" ÷ ");
            entryBox.Text = calculator.resultValue.ToString();
            this.ActiveControl = null;
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.Calculate();

                expressionBox.AppendText(entryBox.Text);
                expressionBox.AppendText(" = ");
                entryBox.Text = calculator.resultValue.ToString();
                this.ActiveControl = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Expressão matemática inválida!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            calculator.Clear();

            entryBox.Text = "0";
            this.ActiveControl = null;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            calculator.Clear();

            expressionBox.Text = "";
            entryBox.Text = "0";
            this.ActiveControl = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            this.ActiveControl = null;
        }

        private void entryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
