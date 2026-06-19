using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            float numberOne = float.Parse(numberOneBox.Text);
            float numberTwo = float.Parse(numberTwoBox.Text);
            calcSymbol.Text = "+";
            float result = numberOne + numberTwo;
            resultLabel.Text = $"{result}";
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            float numberOne = float.Parse(numberOneBox.Text);
            float numberTwo = float.Parse(numberTwoBox.Text);
            calcSymbol.Text = "-";
            float result = numberOne - numberTwo;
            resultLabel.Text = $"{result}";
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            float numberOne = float.Parse(numberOneBox.Text);
            float numberTwo = float.Parse(numberTwoBox.Text);
            calcSymbol.Text = "*";
            float result = numberOne * numberTwo;
            resultLabel.Text = $"{result}";
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            float numberOne = float.Parse(numberOneBox.Text);
            float numberTwo = float.Parse(numberTwoBox.Text);
            calcSymbol.Text = "/";
            float result = numberOne / numberTwo;
            resultLabel.Text = $"{result}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
