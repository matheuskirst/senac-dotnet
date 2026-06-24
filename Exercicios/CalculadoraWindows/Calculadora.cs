using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWindows
{
    public class Calculadora
    {
        public decimal? resultValue = null;
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
                if (resultValue == null)
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
            if (resultValue == null)
            {
                resultValue = decimal.Parse(currentInput);
            }
            resultValue *= resultValue;
        }

        public void Negate()
        {
            resultValue *= -1;
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
            resultValue = null;
            currentInput = "";
            selectedOperator = "";
            isOperatorSelected = false;
        }

        public decimal? GetResult()
        {
            return resultValue;
        }
    }
}
