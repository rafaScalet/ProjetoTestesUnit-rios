using Calculadora.Services;

namespace CalculadoraTeste;

public class ValidarStringTests
{
    private ValidarString validar;

    public ValidarStringTests()
    {
        validar = new ValidarString();
    }

    [Fact]
    public void Contar3CaracteresRetornar3()
    {
        string texto = "olá";

        int resultado = validar.ContarString(texto);

        Assert.Equal(3, resultado);
    }
}