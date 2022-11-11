using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.DataTransferObjects;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Repositories;
using TCC.Estacionamento.Domain.Services;
using TCC.Estacionamento.Domain.ValueObjects;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Services
{
    public class AcelerarVeiculoServiceTeste
    {
        [Fact]
        public void TesteAcelerarQuandoRepositoryRetornaVeiculoEntaoRetornaResultadoDTOComVelocidade()
        {
            //Arrange
            var placa = Placa.Create("PKK-7785");
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

    public class FakeVeiculoRepository : VeiculoRepository
    {
        private Veiculo _veiculo;

        public FakeVeiculoRepository(Veiculo veiculo)
        {
            _veiculo = veiculo;
        }

        public Veiculo ProcurarVeiculoPorPlaca(Placa placa)
        {
            return _veiculo;
        }
    }

    public class FakeVeiculo : Veiculo
    {
        public FakeVeiculo(double valorVelocidade)
        {
            Velocidade = new VelocidadeAtual();
            Velocidade.Value = valorVelocidade;
        }

        public override VelocidadeAtual Acelerar(int tempoSec)
        {
            return Velocidade;
        }
    }
}
