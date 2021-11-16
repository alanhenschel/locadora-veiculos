using System;
using Xunit;
using LocadoraVeiculos.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LocadoraVeiculos.Domain.Test
{
    public class VeiculoTest
    {
        [Fact]
        public Veiculo TestOk()
        {
            var veiculo = new Veiculo
            {
                Marca = "teste",
                Modelo =  "teste",
                Cor = "teste",
                Tipo = "teste"
            };
            return veiculo;
        }

        [Fact]
        public void TestRequired()
        {
            //Arrange
            var veiculo = new Veiculo {};

            //ACT
            var util = new Util();
            var lstErrors = util.ValidateModel(veiculo);

            //ASSERT
            Assert.True(lstErrors.Count == 4);
            //Or 
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Marca é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Modelo é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Cor é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Tipo é obrigatório.")).Count() > 0);
        }
    }
}
