using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Teste.Domain.DoubleTests
{
    public class FakeVeiculo : Veiculo
    {
        public FakeVeiculo(double valorVelocidade)
        {
            Velocidade = new VelocidadeAtual();
            Velocidade.Value = valorVelocidade;
        }

        public override VelocidadeAtual Acelerar(int tempoSec)
        {
            return Velocidade;
        }
    }
}
