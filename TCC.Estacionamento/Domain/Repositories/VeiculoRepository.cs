using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Repositories
{
    public interface VeiculoRepository
    {
        public Veiculo ProcurarVeiculoPorPlaca(Placa placa);

    }

    public class MySqlVeiculoRepository : VeiculoRepository
    {
        public Veiculo ProcurarVeiculoPorPlaca(Placa placa)
        {
            throw new NotImplementedException();
        }
    }
}
