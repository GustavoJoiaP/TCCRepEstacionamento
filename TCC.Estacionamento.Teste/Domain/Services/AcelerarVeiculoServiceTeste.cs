using System;
using TCC.Estacionamento.Domain.DataTransferObjects;
using TCC.Estacionamento.Domain.Services;
using TCC.Estacionamento.Domain.ValueObjects;
using TCC.Estacionamento.Teste.Domain.DoubleTests;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Services
{
    public class AcelerarVeiculoServiceTeste
    {
        [Fact]
        public void TesteAcelerarQuandoRepositoryRetornaVeiculoEntaoRetornaResultadoDTOComVelocidade()
        {
            //Arrange
            var placa = Placa.Create("ASD-9999");
            int tempoSeg = 5;
            double valorVelocidade = 5;
            var veiculo = new FakeVeiculo(valorVelocidade);
            var veiculoRepository = new FakeVeiculoRepository(veiculo);
            var acelerarVeiculoService = new AcelerarVeiculoService(veiculoRepository);
            var acelerarVeiculoDTO = new AcelerarVeiculoDTO(tempoSeg, placa.Value);

            //Action
            var resultadoAcelerarDTO =  acelerarVeiculoService.Acelerar(acelerarVeiculoDTO);

            //Assert
            Assert.Equal(valorVelocidade, resultadoAcelerarDTO.Velocidade);
        }
    }
}
