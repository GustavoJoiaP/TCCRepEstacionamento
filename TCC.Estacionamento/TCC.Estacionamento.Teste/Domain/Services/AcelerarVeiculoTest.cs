using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Services;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Services
{
    public class AcelerarVeiculoTest
    {
        [Fact]
        public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceAcelerarVeiculo()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            int tempoSeg = 5;

            //Action
            AcelerarVeiculoService.Acelerar(tempoSeg, veiculo);

            //Assert
            Assert.Equal(50, veiculo.VelocidadeAtual.Value);
        }
    }
}
