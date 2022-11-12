using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.ValueObjects;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Entities
{
    public class PatioTeste
    {
        [Fact]
        public void TesteRegistrarSaidaVeiculoQuandoRepositoryRetornaVeiculoEntaoRegistreHoraSaidaNoVeiculo()
        {
            //Arrange 
            var veiculo = new Veiculo();
            var horaSaida = DateTime.Now;
            var patio = new Patio();

            //Action
            var retornoMetodoRegistrarSaidaVeiculo = patio.RegistrarSaidaVeiculo(veiculo, horaSaida);

            //Assert
            Assert.Equal(retornoMetodoRegistrarSaidaVeiculo, veiculo.HoraSaida);
        }
    }
}
