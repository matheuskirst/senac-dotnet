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
            calcSymbol.Text = "+";
            Resultado("+");
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            calcSymbol.Text = "-";
            Resultado("-");
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calcSymbol.Text = "*";
            Resultado("*");
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            calcSymbol.Text = "/";
            Resultado("/");
        }

        public void Resultado(string operacao)
        {
            if (float.TryParse(numeroUmBox.Text, out float numeroUm) && float.TryParse(numeroDoisBox.Text, out float numeroDois))
            {
                float resultado;
                switch (operacao)
                {
                    case "+":
                        resultado = Calcular.Somar(numeroUm, numeroDois);
                        resultLabel.Text = $"{resultado}";
                        break;
                    case "-":
                        resultado = Calcular.Subtrair(numeroUm, numeroDois);
                        resultLabel.Text = $"{resultado}";
                        break;
                    case "*":
                        resultado = Calcular.Multiplicar(numeroUm, numeroDois);
                        resultLabel.Text = $"{resultado}";
                        break;
                    case "/":
                        try
                        {
                            resultado = Calcular.Dividir(numeroUm, numeroDois);
                            resultLabel.Text = $"{resultado}";
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Não é possível dividir por zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Operação inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
