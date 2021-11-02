using System;
using System.Collections.Generic;
using System.Text;
using IdadeVotar;
using Xunit;

namespace IdadeVotar_UnitTest
{
    public class Voto_UnitTest
    {
        [Theory]
        [InlineData(14, "Não pode votar")]
        [InlineData(17, "Voto opcional")]
        [InlineData(21, "Pode votar")]
        [InlineData(16, "Voto opcional")]
        [InlineData(18, "Pode votar")]
        [InlineData(-15, "Valor inválido")]
        [InlineData(200, "Valor inválido")]
        public void deveRetornarPodeVotar(int vIdade, string esperado)
        {
            //Act
            var obtido = Voto.podeVotar(vIdade);

            //Assert
            Assert.Equal(esperado, obtido);
        }
    }
}
