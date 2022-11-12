using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Estacionamento.Domain.DataTransferObjects
{
    public class ResultadoRegistrarEntradaVeiculoDTO
    {
        public readonly string Placa;
        public readonly DateTime HoraEntrada;
        public ResultadoRegistrarEntradaVeiculoDTO(string placa, DateTime horaEntrada)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
        }
    }
}
