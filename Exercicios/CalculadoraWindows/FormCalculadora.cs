namespace CalculadoraWindows
{
    public partial class FormCalculadora : Form
    {
        private string? entryNumbers = "";
        private string? expressionNumbers = "";
        private string? lastResult = "";

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
                entryNumbers += e.KeyChar;

                entryBox.Text = "";
                entryBox.Text = entryNumbers;
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

                case Keys.Back: deleteButton_Click(sender, e); break;
            }
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "1";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "2";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "3";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "4";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "5";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "6";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "7";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberEightButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "8";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            entryNumbers += "9";

            entryBox.Text = entryNumbers;
            this.ActiveControl = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            expressionNumbers += entryNumbers;
            expressionNumbers += lastResult;
            expressionNumbers += "+";
            entryNumbers = "";

            expressionBox.Text = "";
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText(" + ");
            this.ActiveControl = null;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            expressionNumbers += entryNumbers;
            expressionNumbers += lastResult;
            expressionNumbers += "-";
            entryNumbers = "";

            expressionBox.Text = "";
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText(" - ");
            this.ActiveControl = null;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            expressionNumbers += entryNumbers;
            expressionNumbers += lastResult;
            expressionNumbers += "*";
            entryNumbers = "";

            expressionBox.Text = "";
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText(" x ");
            this.ActiveControl = null;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            expressionNumbers += entryNumbers;
            expressionNumbers += lastResult;
            expressionNumbers += "/";
            entryNumbers = "";

            expressionBox.Text = "";
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText(" ÷ ");
            this.ActiveControl = null;
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                lastResult = "";
                expressionNumbers += entryNumbers;
                System.Data.DataTable table = new System.Data.DataTable();
                object result = table.Compute(expressionNumbers, "");
                lastResult = result.ToString();
                entryNumbers = "";
                expressionNumbers = "";

                expressionBox.AppendText(entryBox.Text);
                expressionBox.AppendText(" = ");
                entryBox.Text = result.ToString();
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
            entryNumbers = "";

            entryBox.Text = "0";
            this.ActiveControl = null;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            expressionNumbers = "";
            entryNumbers = "";
            lastResult = "";

            expressionBox.Text = "";
            entryBox.Text = "0";
            this.ActiveControl = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (entryNumbers != null && entryNumbers != "")
            {

                entryNumbers = entryNumbers.Remove(entryNumbers.Length - 1);
                entryBox.Text = "";
                entryBox.Text = entryNumbers;
            }

            if (entryNumbers == "" && lastResult == "")
            {
                entryBox.Text = "0";
            }

            if (lastResult != "")
            {
                expressionNumbers = "";

                expressionBox.Text = "";
                entryBox.Text = "";
                entryBox.Text = lastResult;
            }
            this.ActiveControl = null;
        }

        private void entryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
