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
    public class RegistrarEntradaVeiculoService
    {
        private VeiculoRepository _veiculoRepository;
        private Patio _patio;
        public RegistrarEntradaVeiculoService(VeiculoRepository veiculoRepository, Patio patio)
        {
            _veiculoRepository = veiculoRepository;
            _patio = patio;
        }

        public ResultadoRegistrarEntradaVeiculoDTO RegistrarEntradaVeiculo(RegistrarEntradaVeiculoDTO registrarEntradaVeiculoDTO)
        {
            var placa = Placa.Create(registrarEntradaVeiculoDTO.Placa);
            var veiculo = _veiculoRepository.RegistrarVeiculo(placa);
            var horaEntrada =_patio.RegistrarEntradaVeiculo(veiculo, registrarEntradaVeiculoDTO.HoraEntrada);
            
            var resultadoRegistrarEntradaVeiculoDTO = new ResultadoRegistrarEntradaVeiculoDTO(veiculo.Placa.Value, horaEntrada);
            return resultadoRegistrarEntradaVeiculoDTO;
        }
    }
}
