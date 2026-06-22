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
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public void AddDigit(string digit)
        {
            if (digit == "," && currentInput == "") digit = "0,";
            if (digit == "," && currentInput.Contains(',')) return;

            if (isOperationPerformed)
            {
                currentInput = "";
            }
            isOperationPerformed = false;

            currentInput += digit;
        }

        public void SetOperation(string operation)
        {
            isOperationPerformed = true;
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
            operationPerformed = operation;
            currentInput = "";
        }

        public void Calculate()
        {
            if (currentInput != "")
            {
                switch (operationPerformed)
                {
                    case "+":
                        resultValue += decimal.Parse(currentInput);
                        break;
                    case "-":
                        resultValue -= decimal.Parse(currentInput);
                        break;
                    case "*":
                        resultValue *= decimal.Parse(currentInput);
                        break;
                    case "/":
                        if (decimal.Parse(currentInput) != 0)
                        {
                            resultValue /= decimal.Parse(currentInput);
                        }
                        else
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        break;
                }
            }
            currentInput = "";
            operationPerformed = "";
            isOperationPerformed = false;
        }

        public void Clear()
        {
            resultValue = 0;
            currentInput = "";
            operationPerformed = "";
            isOperationPerformed = false;
        }
    }
}
