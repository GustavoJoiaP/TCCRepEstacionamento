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
    public class AcelerarVeiculoService
    {
        private VeiculoRepository _veiculoRepository;
        public AcelerarVeiculoService(VeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
        public ResultadoAcelerarDTO Acelerar(AcelerarVeiculoDTO acelerarVeiculoDTO)
        {
            var placa = Placa.Create(acelerarVeiculoDTO.Placa);

            var veiculo = _veiculoRepository.ProcurarVeiculoPorPlaca(placa);

            var velocidade = veiculo.Acelerar(acelerarVeiculoDTO.TempoSegundo);
            var resultadoAcelerarDTO = new ResultadoAcelerarDTO(velocidade.Value);


            return resultadoAcelerarDTO;
            
        }
    }
}
