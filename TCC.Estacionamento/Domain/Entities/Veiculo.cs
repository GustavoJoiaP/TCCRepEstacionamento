using System;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Entities
{
    public class Veiculo
    {
        public Placa Placa { get; set; }
        private Proprietario _proprietario;
        private TipoVeiculo _tipo;
        public CorVeiculo Cor { get; set; }
        public VelocidadeAtual Velocidade { get; set; }
        public ModeloVeiculo Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }

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
        public TipoVeiculo Tipo { get => _tipo; set => _tipo = value; }

        //Construtor
        public Veiculo()
        {
            
        }

        public Veiculo(Placa placa, VelocidadeAtual velocidade)
        {
            Placa = placa;
            Velocidade = velocidade;
        }

        public Veiculo(string proprietario)
        {
            Proprietario.ProprietarioVeiculo = proprietario;
        }



        public virtual VelocidadeAtual Acelerar(int tempoSeg)
        {
            Velocidade.Value += (tempoSeg * 10);
            return Velocidade;
        }


    }
}
