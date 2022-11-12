using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;

namespace TCC.Estacionamento.Domain.Services
{
    public class RegistrarEntradaVeiculoService
    {
        public static void RegistrarEntradaVeiculo(Veiculo veiculo, Patio estacionamento)
        {
            veiculo.HoraEntrada = DateTime.Now;
            estacionamento.Veiculos.Add(veiculo);
        }
    }
}
