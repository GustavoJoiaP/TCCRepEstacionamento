using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Entities
{
    public class Veiculo
    {
        private Placa _placa;
        private Proprietario _proprietario;
        private TipoVeiculo _tipo;
        public CorVeiculo Cor { get; set; }
        public VelocidadeAtual VelocidadeAtual { get; set; }
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

        public Veiculo(string proprietario)
        {
            Proprietario.ProprietarioVeiculo = proprietario;
        }

    }
}
