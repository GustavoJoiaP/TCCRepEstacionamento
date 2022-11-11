using System;

namespace TCC.Estacionamento.Domain.ValueObjects
{
    public class Placa
    {
        public string _value { get; }

        private Placa(string placaValidValue) {
            _value = placaValidValue;
        }

        public static Placa Create(string rawPlaca){
            ValidatePossuiOitoCaracteres(rawPlaca);
            ValidatePrimeirosTresPrimeirosCaracteresSaoLetras(rawPlaca);
            ValidatePossuiHifenNoQuartoCaracter(rawPlaca);
            ValidateUltimosQuatroCaracteresSaoDigitos(rawPlaca);

            return new Placa(rawPlaca);
        }

        private static void ValidateUltimosQuatroCaracteresSaoDigitos(string rawPlaca) {
            //checa se os 4 ultimos caracteres são numeros
            for (int i = 4; i < 8; i++)
            {
                if (!char.IsDigit(rawPlaca[i]))
                {
                    throw new FormatException("Do 5º ao 8º caractere deve-se ter um número!");
                }
            }
        }
        
        private static void ValidatePossuiHifenNoQuartoCaracter(string rawPlaca) {
            //checa o Hifem
            if (rawPlaca[3] != '-')
            {
                throw new FormatException("O 4° caractere deve ser um hífen");
            }

        }

        private static void ValidatePossuiOitoCaracteres(string rawPlaca) {
            // Checa se o valor possui pelo menos 8 caracteres
            if (rawPlaca.Length != 8)
            {
                throw new FormatException(" A placa deve possuir 8 caracteres");
            }
        }

        
        private static void ValidatePrimeirosTresPrimeirosCaracteresSaoLetras(string rawPlaca) {
            for (int i = 0; i < 3; i++)
            {
                //checa se os 3 primeiros caracteres são numeros
                if (char.IsDigit(rawPlaca[i]))
                {
                    throw new FormatException("Os 3 primeiros caracteres devem ser letras!");
                }
            }
        }
    }
}
