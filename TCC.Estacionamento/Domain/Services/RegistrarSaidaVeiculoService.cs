using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.DataTransferObjects;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Repositories;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Services
{
    public class RegistrarSaidaVeiculoService
    {

        private VeiculoRepository _veiculoRepository;
        private Patio _patio;

        public RegistrarSaidaVeiculoService(Patio patio, VeiculoRepository veiculoRepository)
        {
            _patio = patio;
            _veiculoRepository = veiculoRepository;
        }

        public ResultadoRegistrarSaidaVeiculoDTO RegistrarSaidaVeiculo(RegistrarSaidaVeiculoDTO registrarSaidaVeiculoDTO)
        {
            var placa = Placa.Create(registrarSaidaVeiculoDTO.Placa);
            var veiculo = _veiculoRepository.ProcurarVeiculoPorPlaca(placa);
            var resultadoRegistrarSaidaVeiculo =_patio.RegistrarSaidaVeiculo(veiculo, registrarSaidaVeiculoDTO.HoraSaida);
            var resultadoRegistroSaidaVeiculo = new ResultadoRegistrarSaidaVeiculoDTO(resultadoRegistrarSaidaVeiculo, veiculo.HoraEntrada, veiculo.Placa.Value);
            return resultadoRegistroSaidaVeiculo;
        }
    }
}
