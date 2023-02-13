using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;

namespace TCC.Estacionamento.Teste.Domain.DoubleTests
{
    public class FakePatio : Patio
    {
        public override DateTime RegistrarSaidaVeiculo(Veiculo veiculo, DateTime horaSaida)
        {
            return horaSaida;
        }
    }
}
