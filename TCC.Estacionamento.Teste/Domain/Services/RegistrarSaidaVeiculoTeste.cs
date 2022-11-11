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
    public class RegistrarSaidaVeiculoTeste
    {
        [Fact]
        public void TesteRequisicaoQuandoContemArguemntoValidoEntaoChameServiceRegistrarSaidaVeiculo()
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
            CorVeiculo cor = new CorVeiculo();
            cor.Cor = "Preto";
            veiculo.Cor = cor;
            ModeloVeiculo modelo = new ModeloVeiculo();
            modelo.Modelo = "Fusca";
            veiculo.Modelo = modelo;
            RegistrarEntradaVeiculoServices.RegistrarEntradaVeiculo(veiculo, estacionamento);

            //Act
            //RegistrarSaidaVeiculoServices.RegistrarSaidaVeiculo(veiculo.Placa, estacionamento);

            //Assert
            Assert.DoesNotContain(veiculo, estacionamento.Veiculos);

        }
    }
}
