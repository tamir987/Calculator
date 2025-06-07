namespace Calculator.Services
{
    public interface ICalculatorService
    {
        decimal Calculate(decimal number1, decimal number2, string operation);
    }
}
