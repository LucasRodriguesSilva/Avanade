using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ContagemDeTextoTests
    {
        private ContagemDeTexto _texto;
        public ContagemDeTextoTests()
        {
            _texto = new ContagemDeTexto();
        }
        
        [Fact]
        public void DeveTer_5_NaContagemDeCaracteresDoNome_Lucas()
        {
            // Arrange
            string nome = "Lucas";

            // Act
            int resultado = _texto.QuantidadeDeCaracteres(nome);

            // Assert
            Assert.Equal(5, resultado);

        }
    }
}