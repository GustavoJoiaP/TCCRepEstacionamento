using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.DataTransferObjects;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Repositories;

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
            var resultadoRegistrarEntradaVeiculoDTO = new ResultadoRegistrarEntradaVeiculoDTO();
            return registrarEntradaVeiculoDTO;
        }

        //public static void RegistrarEntradaVeiculo(Veiculo veiculo, Patio estacionamento)
        //{
        //    veiculo.HoraEntrada = DateTime.Now;
        //    estacionamento.Veiculos.Add(veiculo);
        //}
    }
}
