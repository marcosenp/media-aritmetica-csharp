using Xunit;
using MediaApp;

public class MediaTests
{
    [Theory]
    [InlineData(4, 6, 5)]
    [InlineData(0, 0, 0)]
    [InlineData(-10, 10, 0)]
    [InlineData(2.5, 3.5, 3)]
    public void DeveCalcularMediaCorretamente(double num1, double num2, double esperado)
    {
        double resultado = Program.CalcularMedia(num1, num2);
        Assert.Equal(esperado, resultado);
    }
}
