using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Entities
{
    public class Patio
    {
        private List<Veiculo> veiculos;
        private double faturado;
        public Faturamento Faturado { get; set; }
        public List<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }


        public Patio()
        {
            Faturamento faturamento = new Faturamento();
            faturamento.Value = 0;
            Faturado = faturamento;
            veiculos = new List<Veiculo>();
        }
    }
}
