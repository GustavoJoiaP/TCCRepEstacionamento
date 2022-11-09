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


        public Placa Placa
        {
            get
            {
                return _placa;
            }
            set
            {
                // Checa se o valor possui pelo menos 8 caracteres
                if (value.PlacaVeiculo.Length != 8)
                {
                    throw new FormatException(" A placa deve possuir 8 caracteres");
                }
                for (int i = 0; i < 3; i++)
                {
                    //checa se os 3 primeiros caracteres são numeros
                    if (char.IsDigit(value.PlacaVeiculo[i]))
                    {
                        throw new FormatException("Os 3 primeiros caracteres devem ser letras!");
                    }
                }
                //checa o Hifem
                if (value.PlacaVeiculo[3] != '-')
                {
                    throw new FormatException("O 4° caractere deve ser um hífen");
                }
                //checa se os 3 primeiros caracteres são numeros
                for (int i = 4; i < 8; i++)
                {
                    if (!char.IsDigit(value.PlacaVeiculo[i]))
                    {
                        throw new FormatException("Do 5º ao 8º caractere deve-se ter um número!");
                    }
                }
                _placa = value;

            }
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
