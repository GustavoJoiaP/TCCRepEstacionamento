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
        //public readonly double ValorPago;

        public ResultadoRegistrarSaidaVeiculoDTO( DateTime horaSaida, DateTime horaEntrada, string placa)
        {
            //ValorPago = valorPago;
            HoraSaida = horaSaida;
            HoraEntrada = horaEntrada;
            Placa = placa;
        }
    }
}
