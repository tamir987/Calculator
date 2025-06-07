using Calculator.Services;

public class CalculatorServiceTests
{
    private readonly CalculatorService _service = new();

    [Theory]
    [InlineData(4, 2, "add", 6)]
    [InlineData(4, 2, "subtract", 2)]
    [InlineData(4, 2, "multiply", 8)]
    [InlineData(4, 2, "divide", 2)]
    public void Calculate_ReturnsCorrectResult(decimal n1, decimal n2, string op, decimal expected)
    {
        var result = _service.Calculate(n1, n2, op);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculate_DivideByZero_ThrowsDivideByZeroException()
    {
        var ex = Assert.Throws<DivideByZeroException>(() =>
            _service.Calculate(10, 0, "divide"));
        Assert.Equal("Cannot divide by zero.", ex.Message);
    }

    [Fact]
    public void Calculate_InvalidOperation_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() =>
            _service.Calculate(5, 5, "modulus"));
        Assert.Equal("Unsupported operation", ex.Message);
    }
}