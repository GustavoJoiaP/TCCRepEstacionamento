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
    public class RegistrarEntradaVeiculoTeste
    {
        [Fact]
        public void TesteRegistrarEntradaVeiculoQuandoRegistrarEntradaVeiculoNoVeiculoRepositoryEntaoRetorneResultadoRegistrarEntradaVeiculoDTO()
        {
            //Arrange
            var placa = Placa.Create("ASD-9999");
            var horaEntrada = new DateTime(2022, 11, 11);
            int tipoVeiculo = 0;
            var fakePatio = new FakePatio();
            var veiculoRepository = new FakeVeiculoRepository(placa);

            var registrarEntradaVeiculoService = new RegistrarEntradaVeiculoService(veiculoRepository, fakePatio);
            var registrarEntradaVeiculoDTO = new RegistrarEntradaVeiculoDTO(placa.Value, horaEntrada, tipoVeiculo);

            //Action
            var resultadoRegistrarEntradaVeiculo = registrarEntradaVeiculoService.RegistrarEntradaVeiculo(registrarEntradaVeiculoDTO);

            //Asser
            var assertResultadoRegistrarEntradaVeiculoDTO = new ResultadoRegistrarEntradaVeiculoDTO(placa.Value, horaEntrada);
            Assert.Equal(assertResultadoRegistrarEntradaVeiculoDTO, resultadoRegistrarEntradaVeiculo);
        }
        //public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceRegistrarEntradaVeiculo()
        //{
        //    Arragen
        //    Patio estacionamento = new Patio();
        //    Veiculo veiculo = new Veiculo();

        //    Proprietario proprietario = new Proprietario();
        //    proprietario.ProprietarioVeiculo = "André Silva";
        //    veiculo.Proprietario = proprietario;
        //    Placa placa = new Placa();
        //    placa.PlacaVeiculo = "ASD-9999";
        //    veiculo.Placa = placa;

        //    Act
        //    RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(veiculo, estacionamento);

        //    Assert
        //    Assert.Contains(veiculo, estacionamento.Veiculos);
        //}
    }
}
