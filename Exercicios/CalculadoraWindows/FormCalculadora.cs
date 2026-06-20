namespace CalculadoraWindows
{
    public partial class FormCalculadora : Form
    {
        private string? entryNumbers;
        private string? expressionNumbers;

        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void numberOneButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "1";
            entryBox.Text = entryNumbers;
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "2";
            entryBox.Text = entryNumbers;
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "3";
            entryBox.Text = entryNumbers;
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "4";
            entryBox.Text = entryNumbers;
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "5";
            entryBox.Text = entryNumbers;
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "6";
            entryBox.Text = entryNumbers;
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "7";
            entryBox.Text = entryNumbers;
        }

        private void numberEightButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "8";
            entryBox.Text = entryNumbers;
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            entryBox.Text = "";
            entryNumbers += "9";
            entryBox.Text = entryNumbers;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText("+");
            entryNumbers = "";
            expressionNumbers += entryNumbers;
            expressionNumbers += "+";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText("-");
            entryNumbers = "";
            expressionNumbers += entryNumbers;
            expressionNumbers += "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText("x");
            entryNumbers = "";
            expressionNumbers += entryNumbers;
            expressionNumbers += "*";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            expressionBox.AppendText(entryBox.Text);
            expressionBox.AppendText("÷");
            entryNumbers = "";
            expressionNumbers += entryNumbers;
            expressionNumbers += "/";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                expressionBox.AppendText(entryBox.Text);
                object result = table.Compute(expressionBox.Text, string.Empty);
                expressionBox.AppendText("=");
                entryBox.Text = result.ToString();
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
            entryBox.Text = "";
            entryNumbers = string.Empty;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            expressionBox.Text = "";
            entryBox.Text = "";
            entryNumbers += string.Empty;
            expressionNumbers = string.Empty;
        }

    }
}
