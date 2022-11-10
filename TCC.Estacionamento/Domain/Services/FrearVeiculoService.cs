using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Services
{
    public class FrearVeiculoService
    {
        public static void Frear(int tempoSeg, Veiculo veiculo)
        {
            VelocidadeAtual velocidade = new VelocidadeAtual();
            velocidade.Value -= (tempoSeg * 15);
            veiculo.VelocidadeAtual = velocidade;
        }
    }
}
