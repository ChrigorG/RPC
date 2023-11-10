namespace Projeto_RPC_Calculadora_Cliente {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("=============================");
            Console.WriteLine("| Bem vindo a calculadora RPC |");
            Console.WriteLine("=============================");

            MenuPrincipal();

            Console.WriteLine("Saindo...");
            Console.WriteLine("Volte sempre !!");
        }

        public static void MenuPrincipal() {
            string entrada;
            byte resposta;
            do {
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("|       Menu principal de opções         |");
                Console.WriteLine("|      O que você deseja calcular?       |");
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("| 01 - Calcular área                     |");
                Console.WriteLine("| 02 - Calcular Volume                   |");
                Console.WriteLine("| 00 - Desejo Sair                       |");
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine();
                Console.Write("Resposta: ");
                entrada = Console.ReadLine();

                resposta = (byte)(!byte.TryParse(entrada, out resposta) 
                    || entrada == null 
                    ? MensagemEntradaIncorreta() 
                    : Opcoes(byte.Parse(entrada))
                );            

            } while (resposta != 0);
        }

        public static byte Opcoes(byte resposta) {
            switch (resposta) {
                case 1:
                    MenuArea();
                    break;
                case 2:
                    MenuVolume();
                    break;
                default:
                    MensagemEntradaIncorreta();
                    break;
            }
            return resposta;
        }

        public static byte OpcoesArea(byte resposta) {
            switch (resposta) {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
             
                    break;
                case 2:
               
                    break;
                default:
                    MensagemEntradaIncorreta();
                    break;
            }
            return resposta;
        }

        public static byte OpcoesVolume(byte resposta) {
            switch (resposta) {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                default:
                    MensagemEntradaIncorreta();
                    break;
            }
            return resposta;
        }

        public static void MenuArea() {
            string entrada;
            byte resposta;
            do {
                CabecalhoMenu("área");
                Console.WriteLine("| 01 - Área do Quadrado                  |");
                Console.WriteLine("| 02 - Área do Triângulo                 |");
                Console.WriteLine("| 03 - Área do Cilindro                  |");
                Console.WriteLine("| 04 - Área da Esfera                    |");
                Console.WriteLine("| 05 - Área da Circunferência            |");
                Console.WriteLine("| 00 - Desejo voltar ao menu Principal   |");
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine();
                Console.Write("Resposta: ");
                entrada = Console.ReadLine();

                resposta = (byte)(!byte.TryParse(entrada, out resposta)
                    || entrada == null
                    ? MensagemEntradaIncorreta()
                    : OpcoesArea(byte.Parse(entrada))
                );

            } while (resposta != 0);
        }

        public static void MenuVolume() {
            string entrada;
            byte resposta;
            do {
                CabecalhoMenu("volume");
                Console.WriteLine("| 01 - Volume do Esfera                  |");
                Console.WriteLine("| 02 - Volume do Cilindro                |");
                Console.WriteLine("| 03 - Volume do Cubo                    |");
                Console.WriteLine("| 00 - Desejo voltar ao menu Principal   |");
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine();
                Console.Write("Resposta: ");
                entrada = Console.ReadLine();

                resposta = (byte)(!byte.TryParse(entrada, out resposta)
                    || entrada == null
                    ? MensagemEntradaIncorreta()
                    : OpcoesVolume(byte.Parse(entrada))
                );

            } while (resposta != 0);
        }

        public static void CabecalhoMenu(string Titulo) {
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine($"|      Menu principal para {Titulo}     |");
            Console.WriteLine($"|      Qual {Titulo} deseja calcular?   |");
            Console.WriteLine("+----------------------------------------+");
        }

        public static byte MensagemEntradaIncorreta() {
            Console.WriteLine();
            Console.WriteLine("Valor inválido. Por favor, insira um valor de acordo com as opções!");
            Console.WriteLine();
            return 99;
        }
    }
}