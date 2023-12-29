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
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeverVerificarSeNumerosEhPar(int numero)
    {
        // Act
        bool resultado = _calc.EhPar(numero);

    }
}