using System.Net.Http.Metrics;

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

                RefreshEntryBox();
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

                case Keys.Back: backspaceButton_Click(sender, e); break;
            }
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("1");

            RefreshEntryBox();
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("2");

            RefreshEntryBox();
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("3");

            RefreshEntryBox();
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("4");

            RefreshEntryBox();
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("5");

            RefreshEntryBox();
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("6");

            RefreshEntryBox();
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("7");

            RefreshEntryBox();
        }

        private void numberEightButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("8");

            RefreshEntryBox();
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("9");

            RefreshEntryBox();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("0");

            RefreshEntryBox();
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit(",");

            RefreshEntryBox();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("+");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" + ");
            UpdateEntryWithResult();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("-");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" - ");
            UpdateEntryWithResult();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("*");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" x ");
            UpdateEntryWithResult();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("/");

            expressionBox.Text = "";
            expressionBox.AppendText(calculator.resultValue.ToString());
            expressionBox.AppendText(" ÷ ");
            UpdateEntryWithResult();
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {

        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            try
            {
                expressionBox.Text = "";
                expressionBox.AppendText($"sqr({calculator.currentInput})");
                calculator.SetOperation("sqr");
                UpdateEntryWithResult();
            }
            catch (InvalidOperationException)
            {

            }

        }

        private void moreOrLessButton_Click(object sender, EventArgs e)
        {
            calculator.Negate();
            UpdateEntryWithResult();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.Calculate();

                expressionBox.AppendText(entryBox.Text);
                expressionBox.AppendText(" = ");
                UpdateEntryWithResult();
            }
            catch (InvalidOperationException)
            {

            }
            catch (DivideByZeroException)
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
            calculator.ClearEntry();

            RefreshEntryBox();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            calculator.ClearAll();

            expressionBox.Text = "";
            RefreshEntryBox();
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            calculator.Backspace();
            RefreshEntryBox();

            this.ActiveControl = null;
        }

        private void entryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RefreshEntryBox()
        {
            if (calculator.currentInput != "")
            {
                entryBox.Text = calculator.currentInput;
            }
            else
            {
                entryBox.Text = "0";
            }
            this.ActiveControl = null;
        }

        private void UpdateEntryWithResult()
        {
            entryBox.Text = calculator.resultValue.ToString();
            this.ActiveControl = null;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

    }
}
