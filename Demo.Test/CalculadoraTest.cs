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
        public void Calculadora_Somar_ReotnrarValorSoma()
        {
            //Arrange
            var calculadora = new Claculadora();

            //Acet
            var resultado = calculadora.Somar(2, 3);

            //Assert
            Assert.Equal(5, resultado);
        }
    }
}
