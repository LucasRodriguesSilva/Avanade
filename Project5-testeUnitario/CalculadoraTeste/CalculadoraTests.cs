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
    public void DeveSomar10Com15ResultandoEm25()
    {
        // Arrange
        int num1 = 10;
        int num2 = 15;

        // Act
        int resultado = num1 + num2;

        // Assert

        Assert.Equal(25, resultado);
    }
}