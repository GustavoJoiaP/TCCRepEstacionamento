using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Estacionamento.Domain.DataTransferObjects
{
    public class RegistrarEntradaVeiculoDTO
    {
        public readonly string Placa;
        public readonly DateTime HoraEntrada;
        public readonly int TipoVeiculo;
        public RegistrarEntradaVeiculoDTO(string placa, DateTime horaEntrada, int tipoVeiculo)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
            TipoVeiculo = tipoVeiculo;
        }
    }
}
