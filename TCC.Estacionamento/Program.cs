using System;
using TCC.Estacionamento.Domain.Entities;
using TCC.Estacionamento.Domain.Services;
using TCC.Estacionamento.Domain.ValueObjects;

namespace TCC.Estacionamento
{
    class Program
    {
        // Cria uma lista de objetos do tipo veículos, para armazenar
        // os veículos (automovéis e motos) que estão no estacionamento;
        static Patio estacionamento = new Patio();

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine(MostrarCabecalho());
                Console.WriteLine(MostrarMenu());
                opcao = LerOpcaoMenu();
                ProcessarOpcaoMenu(opcao);
                PressionaTecla();
                Console.Clear();// limpa a tela;
            } while (opcao != "5");
        }


        // Métodos de negócios.
        static void MostrarVeiculosEstacionados()
        {
            Console.Clear();
            Console.WriteLine(" Veículos Estacionados");
            foreach (Veiculo v in estacionamento.Veiculos)
            {
                // placa, propr, hora
                //Console.WriteLine("Placa :{0}", v.Placa.PlacaVeiculo);
                Console.WriteLine("Proprietário :{0}", v.Proprietario.ProprietarioVeiculo);
                Console.WriteLine("Hora de entrada :{0:HH:mm:ss}", v.HoraEntrada);
                Console.WriteLine("********************************************");

            }
            if (estacionamento.Veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados no momento...");
            }

        }

        static void RegistrarSaidaVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Registro de Saída de Veículos");
            Console.Write("Placa: ");
            //Placa placa = new Placa();
            //placa.PlacaVeiculo = Console.ReadLine();
            //Console.WriteLine(RegistrarSaidaVeiculoServices.RegistrarSaidaVeiculo(placa, estacionamento));

        }

        static void RegistrarEntradaVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Registro de Entrada de Veículos");
            Console.Write("Tipo de veículo (1-Carro; 2-Moto) :");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    RegistrarEntradaAutomovel();
                    break;
                case "2":
                    RegistrarEntradaMotocicleta();
                    break;
                default:
                    Console.WriteLine("Tipo Inválido");
                    break;
            }
        }

        static void RegistrarEntradaMotocicleta()
        {
            Console.WriteLine("Dados da Motocicleta");
            Veiculo moto = new Veiculo();
            moto.Tipo = TipoVeiculo.Motocicleta;
            //preeencher placa,cor,hora,entrada e proprietário
            Console.Write("Digite os dados da placa (XXX-9999): ");
            try
            {
                //Placa placa = new Placa();
                //placa.PlacaVeiculo = Console.ReadLine();
                //moto.Placa = placa;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("ocorreu um problema: {0}", fe.Message);
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                return;
            }
            Console.Write("Digite a cor da moto: ");
            Console.Write("Digite o nome do proprietário: ");
            Proprietario proprietario = new Proprietario();
            proprietario.ProprietarioVeiculo = Console.ReadLine();
            moto.Proprietario = proprietario;
            moto.HoraEntrada = DateTime.Now;
            //AcelerarVeiculoService.Acelerar(5, moto);
            FrearVeiculoService.Frear(5, moto);
            RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(moto, estacionamento);
            Console.WriteLine("Motocicleta registrada com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();
        }

        static void RegistrarEntradaAutomovel()
        {
            Console.WriteLine("Dados do Automovél");
            Veiculo carro = new Veiculo();
            carro.Tipo = TipoVeiculo.Automovel;
            //preeencher placa,cor,hora,entrada e proprietário.
            Console.Write("Digite os dados da placa (XXX-9999): ");
            try
            {
                //Placa placa = new Placa();
                //placa.PlacaVeiculo = Console.ReadLine();
                //carro.Placa = placa;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("ocorreu um problema: {0}", fe.Message);
                PressionaTecla();
                return;
            }
            Console.Write("Digite o nome do proprietário: ");
            Proprietario proprietario = new Proprietario();
            proprietario.ProprietarioVeiculo = Console.ReadLine();
            carro.Proprietario = proprietario;
            carro.HoraEntrada = DateTime.Now;
            //AcelerarVeiculoService.Acelerar(5, carro);
            FrearVeiculoService.Frear(5, carro);
            RegistrarEntradaVeiculoService.RegistrarEntradaVeiculo(carro, estacionamento);
            PressionaTecla();
        }

        // Monta a interface da aplicação.
        static string MostrarCabecalho()
        {
            return "Controle de Estacionamento Rotativo";
        }

        static string LerOpcaoMenu()
        {
            string opcao;
            Console.Write("Opção desejada: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        static string MostrarMenu()
        {
            string menu = "Escolha uma opção:\n" +
                            "1 - Registrar Entrada\n" +
                            "2 - Registrar Saída\n" +
                            "3 - Exibir Faturamento\n" +
                            "4 - Mostrar Veículos Estacionados\n" +
                            "5 - Sair do Programa \n";
            return menu;
        }

        private static void PressionaTecla()
        {
            Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();
        }

        static void ProcessarOpcaoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    RegistrarEntradaVeiculo();
                    break;
                case "2":
                    RegistrarSaidaVeiculo();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(MostrarFaturamentoService.MostrarFaturamento(estacionamento));
                    break;
                case "4":
                    MostrarVeiculosEstacionados();
                    break;
                case "5":
                    Console.WriteLine("Obrigado por utilizar o programa.");
                    break;
                default:
                    Console.WriteLine("Opção de menu inválida!");
                    break;
            }
        }

    }
}
