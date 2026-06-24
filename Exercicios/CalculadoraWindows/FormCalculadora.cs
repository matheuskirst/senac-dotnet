using System.Net.Http.Metrics;
using System.Linq;
using System.Globalization;

namespace CalculadoraWindows
{
    public partial class FormCalculadora : Form
    {
        CultureInfo brazilCulture = new CultureInfo("pt-BR");
        private Calculadora calculator = new Calculadora();
        private bool _isButtonClicked = false;
        public FormCalculadora()
        {
            InitializeComponent();
            entryBox.Text = "0";
            this.KeyPreview = true;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }


        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                calculator.AddDigit(e.KeyChar.ToString());

                RefreshUi();

                foreach (Button btn in buttonsLayoutPanel.Controls.OfType<Button>())
                {
                    if (btn.Text == e.KeyChar.ToString())
                    {
                        ButtonClicked(btn);
                    }
                }
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

                case Keys.Oemcomma: commaButton_Click(sender, e); break;
            }
        }

        private void RefreshUi(Button? button = null)
        {
            if (calculator.currentInput != "")
            {
                decimal? entryNumber = decimal.Parse(calculator.currentInput);
                entryBox.Text = entryNumber.Value.ToString("#,##0.############################", brazilCulture);
            }
            else
            {
                entryBox.Text = "0";
            }

            if (button != null)
            {
                ButtonClicked(button);
            }

            this.ActiveControl = null;
        }

        private void UpdateEntryWithResult()
        {
            decimal? result = calculator.GetResult();
            entryBox.Text = result.Value.ToString("#,##0.############################", brazilCulture);
            this.ActiveControl = null;
        }

        private async void ButtonClicked(Button button, Color? color = null)
        {
            if (_isButtonClicked) return;

            _isButtonClicked = true;
            try
            {
                Color selectedColor = color ?? Color.LightGray;

                Color originalColor = button.BackColor;

                button.BackColor = selectedColor;

                await Task.Delay(100);

                button.BackColor = originalColor;
                this.ActiveControl = null;
            }
            finally
            {
                _isButtonClicked = false;
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            calculator.Backspace();
            RefreshUi(backspaceButton);
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("1");
            RefreshUi(numberOneButton);
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("2");
            RefreshUi(numberTwoButton);
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("3");
            RefreshUi(numberThreeButton);
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("4");
            RefreshUi(numberFourButton);
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("5");
            RefreshUi(numberFiveButton);
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("6");
            RefreshUi(numberSixButton);
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("7");
            RefreshUi(numberSevenButton);
        }

        private void numberEightButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("8");
            RefreshUi(numberEightButton);
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("9");

            RefreshUi(numberNineButton);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("0");

            RefreshUi(numberZeroButton);
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit(",");
            RefreshUi(commaButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("+");

            expressionBox.Text = "";
            expressionBox.AppendText($"{calculator.GetResult()} + ");
            UpdateEntryWithResult();
            ButtonClicked(addButton);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("-");

            expressionBox.Text = "";
            expressionBox.AppendText($"{calculator.GetResult()} - ");
            UpdateEntryWithResult();
            ButtonClicked(subtractButton);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("*");

            expressionBox.Text = "";
            expressionBox.AppendText($"{calculator.GetResult()} x ");
            UpdateEntryWithResult();
            ButtonClicked(multiplyButton);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator.SetOperation("/");

            expressionBox.Text = "";
            expressionBox.AppendText($"{calculator.GetResult()} ÷ ");
            UpdateEntryWithResult();
            ButtonClicked(divideButton);
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {

        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            try
            {

                expressionBox.Text = "";
                decimal? result = calculator.GetResult();
                if (result == null)
                {
                    result = decimal.Parse(calculator.currentInput);
                }
                expressionBox.AppendText($"sqr({result})");
                calculator.SetOperation("sqr");
                UpdateEntryWithResult();
                ButtonClicked(squareButton);
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

            RefreshUi(clearEntryButton);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            calculator.ClearAll();

            expressionBox.Text = "";
            RefreshUi(clearAllButton);
        }
    }
}
