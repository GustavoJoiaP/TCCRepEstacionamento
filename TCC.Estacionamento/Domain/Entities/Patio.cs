using System;
using System.Collections.Generic;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Entities
{
    public class Patio
    {
        private List<Veiculo> veiculos;
        private double faturado;
        public Faturamento Faturado { get; set; }
        public List<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }
        
        public Patio()
        {
            Faturamento faturamento = new Faturamento();
            faturamento.Value = 0;
            Faturado = faturamento;
            veiculos = new List<Veiculo>();
        }

        public virtual DateTime RegistrarSaidaVeiculo(Veiculo veiculo, DateTime horaSaida)
        {
            veiculo.HoraSaida = horaSaida;
            return veiculo.HoraSaida.Value;
        }

        public virtual Veiculo RegistrarEntradaVeiculo(Placa placa, DateTime horaEntrada, TipoVeiculo tipoVeiculo)
        {
            var velocidade = new VelocidadeAtual();
            velocidade.Value = 5;
            var veiculo = new Veiculo(placa, velocidade, tipoVeiculo, horaEntrada, null);
            return veiculo;
        }

        public virtual List<Veiculo> AdicionarVeiculoNoPatio(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
            return Veiculos;
        }

        public virtual TipoVeiculo IdentificacaoTipoVeiculo(int inputTipoVeiculo)
        {
            if(inputTipoVeiculo == 0)
            {
                var tipoVeiculoAutomovel = TipoVeiculo.Automovel;
                return tipoVeiculoAutomovel;
            }
            else
            {
                var tipoVeiculoMotocicleta = TipoVeiculo.Motocicleta;
                return tipoVeiculoMotocicleta;
            }
        }


    }
}
