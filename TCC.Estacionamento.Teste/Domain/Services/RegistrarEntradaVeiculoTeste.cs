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
    public class RegistrarEntradaVeiculoTeste
    {
        [Fact]
        public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceRegistrarEntradaVeiculo()
        {
            //Arragen
            Patio estacionamento = new Patio();
            Veiculo veiculo = new Veiculo();

            Proprietario proprietario = new Proprietario();
            proprietario.ProprietarioVeiculo = "André Silva";
            veiculo.Proprietario = proprietario;
            //Placa placa = new Placa();
            //placa.PlacaVeiculo = "ASD-9999";
            //veiculo.Placa = placa;

            //Act
            RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(veiculo, estacionamento);

            //Assert
            Assert.Contains(veiculo, estacionamento.Veiculos);
        }
    }
}
