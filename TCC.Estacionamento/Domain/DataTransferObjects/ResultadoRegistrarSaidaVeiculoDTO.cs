using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Estacionamento.Domain.DataTransferObjects
{
    public struct ResultadoRegistrarSaidaVeiculoDTO
    {
        public readonly string Placa;
        public readonly DateTime HoraEntrada;
        public readonly DateTime HoraSaida;


        public ResultadoRegistrarSaidaVeiculoDTO( DateTime horaSaida, DateTime horaEntrada, string placa)
        {
            HoraSaida = horaSaida;
            HoraEntrada = horaEntrada;
            Placa = placa;
        }
    }
}
