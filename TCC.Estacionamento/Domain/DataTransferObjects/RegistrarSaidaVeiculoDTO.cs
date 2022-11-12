using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Estacionamento.Domain.DataTransferObjects
{
    public class RegistrarSaidaVeiculoDTO
    {
        public readonly string Placa;
        public readonly DateTime HoraSaida;

        public RegistrarSaidaVeiculoDTO(DateTime horaSaida, string placa)
        {
            HoraSaida = horaSaida;
            Placa = placa;
        }
    }
}
