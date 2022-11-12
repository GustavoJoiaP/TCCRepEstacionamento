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
        private Patio _patio;
        public RegistrarEntradaVeiculoService(VeiculoRepository veiculoRepository, Patio patio)
        {
            _patio = patio;
        }

        public ResultadoRegistrarEntradaVeiculoDTO RegistrarEntradaVeiculo(RegistrarEntradaVeiculoDTO registrarEntradaVeiculoDTO)
        {
            var placa = Placa.Create(registrarEntradaVeiculoDTO.Placa);
            var tipoVeiculo = TipoVeiculo
            _patio.RegistrarEntradaVeiculo(placa, registrarEntradaVeiculoDTO.HoraEntrada, registrarEntradaVeiculoDTO.TipoVeiculo)

            var resultadoRegistrarEntradaVeiculoDTO = new ResultadoRegistrarEntradaVeiculoDTO();
            return resultadoRegistrarEntradaVeiculoDTO;
        }

        //public static void RegistrarEntradaVeiculo(Veiculo veiculo, Patio estacionamento)
        //{
        //    veiculo.HoraEntrada = DateTime.Now;
        //    estacionamento.Veiculos.Add(veiculo);
        //}
    }
}
