using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWindows
{
    public class Calculadora
    {
        public decimal resultValue = 0;
        public string currentInput = "";
        string selectedOperator = "";
        bool isOperatorSelected = false;

        public void AddDigit(string digit)
        {
            if (digit == "," && currentInput == "") digit = "0,";
            if (digit == "," && currentInput.Contains(',')) return;

            if (isOperatorSelected)
            {
                currentInput = "";
            }

            currentInput += digit;
        }

        public void SetOperation(string operatorSymbol)
        {
            isOperatorSelected = true;
            if (currentInput != "")
            {
                if (resultValue == 0)
                {
                    resultValue = decimal.Parse(currentInput);
                }
                else
                {
                    Calculate();
                }
            }

            selectedOperator = operatorSymbol;

            if (selectedOperator == "sqr")
            {
                Calculate();
            }
            else
            {
                currentInput = "";
            }
        }

        public void Calculate()
        {
            switch (selectedOperator)
            {
                case "+":
                    Addition();
                    break;
                case "-":
                    Subtraction();
                    break;
                case "*":
                    Multiplication();
                    break;
                case "/":
                    Division();
                    break;
                case "sqr":
                    Square();
                    break;
            }
            selectedOperator = "";
            isOperatorSelected = false;
        }

        public void Addition()
        {
            if (currentInput != "")
            {
                resultValue += decimal.Parse(currentInput);
            }
        }

        public void Subtraction()
        {
            if (currentInput != "")
            {
                resultValue -= decimal.Parse(currentInput); ;
            }
        }
        public void Multiplication()
        {
            if (currentInput != "")
            {
                resultValue *= decimal.Parse(currentInput);
            }
        }
        public void Division()
        {
            if (currentInput != "")
            {
                if (decimal.Parse(currentInput) != 0)
                {
                    resultValue /= decimal.Parse(currentInput);
                }
                else
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
            }
        }

        public void Square()
        {
            if (double.TryParse(currentInput, out double result))
            {
                try
                {
                    resultValue = (decimal)Math.Pow(result, 2);
                    currentInput = resultValue.ToString();
                }
                catch (FormatException)
                {

                }
            }
        }

        public void Negate()
        {
            if (currentInput != "" && resultValue == 0)
            {
                resultValue = decimal.Parse(currentInput) * -1;
            }
            else if (currentInput == "" && resultValue != 0)
            {
                resultValue *= -1;
            }
        }

        public void Backspace()
        {
            if (currentInput != "")
            {
                currentInput = currentInput.Remove(currentInput.Length - 1);
            }
        }

        public void ClearEntry()
        {
            if (isOperatorSelected)
            {
                currentInput = "";
            }
        }

        public void ClearAll()
        {
            resultValue = 0;
            currentInput = "";
            selectedOperator = "";
            isOperatorSelected = false;
        }
    }
}
