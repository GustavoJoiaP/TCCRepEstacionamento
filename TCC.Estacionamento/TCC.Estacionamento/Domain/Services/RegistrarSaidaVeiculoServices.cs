using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento.Domain.Services
{
    public class RegistrarSaidaVeiculoServices
    {
        public static string RegistrarSaidaVeiculo(Placa placa, Patio estacionamento)
        {
            Veiculo procurado = null;
            string informacao = string.Empty;

            foreach (Veiculo v in estacionamento.Veiculos)
            {
                if (v.Placa.PlacaVeiculo == placa.PlacaVeiculo)
                {
                    v.HoraSaida = DateTime.Now;
                    TimeSpan tempoPermanencia = v.HoraSaida - v.HoraEntrada;
                    double valorASerCobrado = 0;
                    if (v.Tipo == TipoVeiculo.Automovel)
                    {
                        /// o método Math.Ceiling(), aplica o conceito de teto da matemática onde o valor máximo é o inteiro imediatamente posterior a ele.
                        /// Ex.: 0,9999 ou 0,0001 teto = 1
                        /// Obs.: o conceito de chão é inverso e podemos utilizar Math.Floor();
                        valorASerCobrado = Math.Ceiling(tempoPermanencia.TotalHours) * 2;

                    }
                    if (v.Tipo == TipoVeiculo.Motocicleta)
                    {
                        valorASerCobrado = Math.Ceiling(tempoPermanencia.TotalHours) * 1;
                    }
                    informacao = string.Format(" Hora de entrada: {0: HH: mm: ss}\n " +
                                             "Hora de saída: {1: HH:mm:ss}\n " +
                                             "Permanência: {2: HH:mm:ss} \n " +
                                             "Valor a pagar: {3:c}", v.HoraEntrada, v.HoraSaida, new DateTime().Add(tempoPermanencia), valorASerCobrado);
                    procurado = v;
                    Faturamento faturamento = new Faturamento();
                    faturamento.Value = estacionamento.Faturado.Value + valorASerCobrado;
                    estacionamento.Faturado = faturamento;
                    break;
                }

            }
            if (procurado != null)
            {
                estacionamento.Veiculos.Remove(procurado);
            }
            else
            {
                return "Não encontrado veículo com a placa informada.";
            }

            return informacao;
        }
    }
}
