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
        private VelocidadeAtual _velocidade;
        public void SetUp()
        {
            _velocidade.Value = 5;
        }

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

        [Fact]
        public void TesteRegistrarEntradaVeiculoQuandoRegistrarEntradaVeiculoDTOPassarValoresEntaoRetorneUmVeiculo()
        {
            //Arrange
            var placa = Placa.Create("ASD-9999");
            var horaEntrada = DateTime.Now;
            var tipoVeiculo = TipoVeiculo.Automovel;
            var patio = new Patio();

            //Action
            var retornoMetodoResgistrarEntradaVeiculo = patio.RegistrarEntradaVeiculo(placa, horaEntrada, tipoVeiculo);

            //Assert
            var veiculoAssert = new Veiculo(placa, _velocidade, tipoVeiculo, horaEntrada, null);
            Assert.Equal(retornoMetodoResgistrarEntradaVeiculo, veiculoAssert.HoraEntrada);
        }

        [Fact]
        public void TesteAdicionarVeiculoNoPatioQuandoMetodoRegistrarEntradaVeiculoPassarVeiculoEntaoRetorneVeiculos()
        {
            //Arrange
            var veiculo = new Veiculo();
            var patio = new Patio();

            //Action
            var veiculos = patio.AdicionarVeiculoNoPatio(veiculo);

            //Assert
            Assert.Contains(veiculo, veiculos);
        }

    }
}
