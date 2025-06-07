using System;

namespace Calculator.Services
{
    /// <summary>
    /// Provides math calculation logic.
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        /// <summary>
        /// Calculates a result based on the given numbers and operation.
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <param name="operation">Math operation (add, subtract, multiply, divide)</param>
        /// <returns>Result of the calculation</returns>
        public decimal Calculate(decimal number1, decimal number2, string operation)
        {
            return operation.ToLower() switch
            {
                "add" => number1 + number2,
                "subtract" => number1 - number2,
                "multiply" => number1 * number2,
                "divide" => number2 == 0
                    ? throw new DivideByZeroException("Cannot divide by zero.")
                    : number1 / number2,
                _ => throw new ArgumentException("Unsupported operation")
            };
        }
    }
}
