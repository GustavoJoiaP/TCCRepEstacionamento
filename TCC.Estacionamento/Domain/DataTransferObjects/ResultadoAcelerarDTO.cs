using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Estacionamento.Domain.DataTransferObjects
{
    public class ResultadoAcelerarDTO
    {
        public readonly double Velocidade;
        public ResultadoAcelerarDTO(double velocidade)
        {
            Velocidade = velocidade;
        }
    }
}
