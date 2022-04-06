using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Test
{

    public class CalculadoraTest
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Claculadora();

            //Acet
            var resultado = calculadora.Somar(2, 3);

            //Assert
            Assert.Equal(5, resultado);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5.0,7,12)]
        [InlineData(0.5,0.5,1)]
        [InlineData(1.5,1.5,3)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Claculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
