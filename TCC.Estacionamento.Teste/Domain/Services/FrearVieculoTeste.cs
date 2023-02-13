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
    public class FrearVieculoTeste
    {
        [Fact]
        public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceFrearVeiculo()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            int tempoSeg = 10;

            //Action
            FrearVeiculoService.Frear(tempoSeg, veiculo);

            //Assert
            Assert.Equal(-150, veiculo.Velocidade.Value);
        }
    }
}
