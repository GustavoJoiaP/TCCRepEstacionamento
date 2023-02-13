using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Services;
using TCC.Estacionamento.Domain.ValueObjects;
using Xunit;

namespace TCC.Estacionamento.Teste.Domain.Services
{
    public class MostrarFaturamentoTeste
    {
        [Fact]
        public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceMostrarFaturamento()
        {
            //Arrange
            //Patio estacionamento = new Patio();
            //List<Veiculo> veiculos = new List<Veiculo>();
            //Veiculo veiculo = new Veiculo();

            //Proprietario proprietario = new Proprietario();
            //proprietario.ProprietarioVeiculo = "André Silva";
            //veiculo.Proprietario = proprietario;
            //Placa placa = new Placa();
            //placa.PlacaVeiculo = "ASD-9999";
            //veiculo.Placa = placa;
            //RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(veiculo, estacionamento);
            //RegistrarSaidaVeiculoServices.RegistrarSaidaVeiculo(veiculo.Placa, estacionamento);

            //Act
            //string faturamento = MostrarFaturamentoService.MostrarFaturamento(estacionamento);

            //Assert
            //Assert.Equal(String.Format("Total faturado até o momento :::::::::::::::::::::::::::: {0:c}", estacionamento.Faturado.Value), faturamento);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        [InlineData("Jose Silva", "POL-9242", "Cinza", "Fusca")]
        [InlineData("Maria Silva", "GDR-6524", "Azul", "Opala")]
        public void TesteRequisicaoQuandoContemArguemntosValidoEntaoChameServiceMostrarFaturamento(string a_proprietario,
                                                        string a_placa,
                                                        string a_cor,
                                                        string a_modelo)
        {
            //Arrange
            //Patio estacionamento = new Patio();
            //List<Veiculo> veiculos = new List<Veiculo>();
            //Veiculo veiculo = new Veiculo();

            //Proprietario proprietario = new Proprietario();
            //proprietario.ProprietarioVeiculo = a_proprietario;
            //veiculo.Proprietario = proprietario;
            //Placa placa = new Placa();
            //placa.PlacaVeiculo = a_placa;
            //veiculo.Placa = placa;
            //RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(veiculo, estacionamento);
            //RegistrarSaidaVeiculoServices.RegistrarSaidaVeiculo(veiculo.Placa, estacionamento);

            //Act
            //string faturamento = MostrarFaturamentoService.MostrarFaturamento(estacionamento);

            //Assert
            //Assert.Equal(String.Format("Total faturado até o momento :::::::::::::::::::::::::::: {0:c}", estacionamento.Faturado.Value), faturamento);
        }
    }
}
