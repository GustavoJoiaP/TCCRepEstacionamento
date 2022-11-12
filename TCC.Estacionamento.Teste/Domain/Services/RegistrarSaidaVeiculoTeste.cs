using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.DataTransferObjects;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Services;
using TCC.Estacionamento.Domain.ValueObjects;
using TCC.Estacionamento.Teste.Domain.DoubleTests;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Services
{
    public class RegistrarSaidaVeiculoTeste
    {
        private TipoVeiculo _tipoVeiculo;
        private VelocidadeAtual _velocidade;
        public void SetUp()
        {
            _velocidade.Value = 5;
            _tipoVeiculo = TipoVeiculo.Automovel;

        }

        [Fact]
        public void TesteRegistrarSaidaVeiculoQuandoRepositoryRetornaVeiculoEntaoRetornaResultadoRegistrarSaidaVeiculoDTO()
        {
            //Arrange
            var placa = Placa.Create("ASD-9999");
            var horaEntrada = new DateTime(2022, 11, 11);
            var horaSaida = new DateTime(2022, 11, 12);
            var veiculo = new Veiculo(placa, _velocidade, _tipoVeiculo, horaEntrada, horaSaida);
            var fakePatio = new FakePatio();
            var veiculoRepository = new FakeVeiculoRepository(veiculo);

            var registrarSaidaVeiculoService = new RegistrarSaidaVeiculoService(fakePatio, veiculoRepository);
            var registrarSaidaVeiculoDTO = new RegistrarSaidaVeiculoDTO(horaSaida, placa.Value);

            //Action
            var resultadoRegistrarSaidaVeiculoDTO = registrarSaidaVeiculoService.RegistrarSaidaVeiculo(registrarSaidaVeiculoDTO);

            //Assert
            var assertResultadoRegistrarSaidaVeiculoDTO = new ResultadoRegistrarSaidaVeiculoDTO(horaSaida, horaEntrada, placa.Value);
            Assert.Equal(assertResultadoRegistrarSaidaVeiculoDTO, resultadoRegistrarSaidaVeiculoDTO);
        }
    }
}
