using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImp calc;

    public CalculadoraTests()
    {
        calc = new CalculadoraImp();
    }

    [Fact]
    public void Somar2e3eRetornar5()
    {
        int num1 = 2;
        int num2 = 3;

        int resultado = calc.Somar(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8, 10})]
    public void Verificar4EparRetornarVerdadeiro(int[] numeros)
    {
        Assert.All(numeros, num => Assert.True(calc.EPar(num)));
    }
}