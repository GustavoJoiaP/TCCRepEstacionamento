using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Repositories;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Teste.Domain.DoubleTests
{
    public class FakeVeiculoRepository : VeiculoRepository
    {
        private Veiculo _veiculo;
        private Placa _placa;

        public FakeVeiculoRepository(Veiculo veiculo)
        {
            _veiculo = veiculo;
        }
        public FakeVeiculoRepository(Placa placa)
        {
            _placa = placa;
        }

        public Veiculo ProcurarVeiculoPorPlaca(Placa placa)
        {
            return _veiculo;
        }

        public Placa RegistrarVeiculoNoPatio(Placa placa)
        {
            return _placa;
        }
    }
}
