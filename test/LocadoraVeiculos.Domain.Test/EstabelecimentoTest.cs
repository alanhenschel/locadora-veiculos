using System;
using Xunit;
using LocadoraVeiculos.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraVeiculos.Domain.Test
{
    public class EstabelecimentoTest
    {
        [Fact]
        public Estabelecimento TestOk()
        {
            var estabelecimento = new Estabelecimento
            {

                Nome = "teste1",

                CNPJ = "teste1",

                Endereco = "teste1",

                Telefone = "teste1",

                QtdVagasMotos = 1,

                QtdVagasCarros = 1
            };
            return estabelecimento;
        }

        [Fact]
        public void TestRequired()
        {
            //Arrange
            var estabelecimento = new Estabelecimento {};

            //ACT
            var util = new Util();
            var lstErrors = util.ValidateModel(estabelecimento);

            //ASSERT
            Assert.True(lstErrors.Count == 6);
            //Or 
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Endereco é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Nome é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo CNPJ é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("O campo Telefone é obrigatório.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("Valor precisa ser maior que 0.")).Count() > 0);
            Assert.True(lstErrors.Where(x => x.ErrorMessage.Contains("Valor precisa ser maior que 0.")).Count() > 0);
        }
    }
}
