using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputConverter = new InputConverter();
                var calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
