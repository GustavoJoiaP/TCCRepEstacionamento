using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;

namespace TCC.Estacionamento.Domain.Services
{
    public class MostrarFaturamentoService
    {
        public static string MostrarFaturamento(Patio estacionamento)
        {
            string totalfaturado = String.Format("Total faturado até o momento :::::::::::::::::::::::::::: {0:c}", estacionamento.Faturado.Value);
            return totalfaturado;
        }
    }
}
