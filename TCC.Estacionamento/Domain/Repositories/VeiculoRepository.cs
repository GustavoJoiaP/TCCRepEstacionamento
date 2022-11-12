﻿using System;
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