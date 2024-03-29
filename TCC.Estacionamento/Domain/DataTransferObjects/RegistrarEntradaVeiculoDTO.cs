﻿using System;
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
        public RegistrarEntradaVeiculoDTO(string placa, DateTime horaEntrada)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
        }
    }
}
