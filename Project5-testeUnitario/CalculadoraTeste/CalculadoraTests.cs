using System.Runtime.CompilerServices;
using Calculadora.Services;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar_10Mais15_ResultandoEm_25()
    {
        // Arrange
        int num1 = 10;
        int num2 = 15;

        // Act
        int resultado = num1 + num2;

        // Assert

        Assert.Equal(25, resultado);
    }

    [Fact]
    public void DeveVerificarSe_4_EhPar()
    {
        // Arrange
        int NumeroPar = 4;

        // Act
        bool resultado = _calc.EhPar(NumeroPar);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void DeverVerificarSeNumerosEhPar(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}