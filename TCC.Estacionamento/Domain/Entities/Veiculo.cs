using System;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Entities
{
    public class Veiculo
    {
        public Placa Placa { get; set; }
        private Proprietario _proprietario;
        private TipoVeiculo _tipo;
        public const double Aceleracao = 10;
        public VelocidadeAtual Velocidade { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }
        public TipoVeiculo TipoVeiculo { get => _tipo; set => _tipo = value; }

        //Construtor
        public Veiculo(Placa placa, VelocidadeAtual velocidade, TipoVeiculo tipo, DateTime horaEntrada, DateTime? horaSaida)
        {
            Placa = placa;
            Velocidade = velocidade;
            TipoVeiculo = tipo;
            HoraEntrada = horaEntrada;
            HoraSaida = horaSaida;
        }

        public Proprietario Proprietario
        {
            get
            {
                return _proprietario;
            }
            set
            {
                if (value.ProprietarioVeiculo.Length < 3)
                {
                    throw new System.FormatException(" Nome de proprietário deve ter no mínimo 3 caracteres.");
                }
                _proprietario = value;
            }

        }
        
        public virtual VelocidadeAtual Acelerar(int tempoSeg)
        {
            Velocidade.Value += (tempoSeg * Aceleracao);
            return Velocidade;
        }

        public Veiculo()
        {

        }

        public virtual TipoVeiculo IdentificacaoTipoVeiculo(int inputTipoVeiculo)
        {
            if (inputTipoVeiculo == 0)
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
