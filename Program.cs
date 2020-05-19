using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                InputConverter inputConverter = new InputConverter();
           CalculatorEngine calculatorEngine = new CalculatorEngine();

           double firstNumber = inputConverter.ConverInputToNumberic(Console.ReadLine());
           double secondNumber = inputConverter.ConverInputToNumberic(Console.ReadLine());
           string operation = Console.ReadLine();

           double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

           Console.WriteLine(result);
            }
           catch (Exception ex)
           {
               //In real worl we would want to log this message
               Console.WriteLine(ex.Message);
           }
        }
    }
}