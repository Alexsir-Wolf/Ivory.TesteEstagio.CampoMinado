using System;
using static Ivory.TesteEstagio.CampoMinado.CampoMinado;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine($"{campoMinado.Tabuleiro}\n");

            // Realize sua codificação a partir deste ponto, boa sorte!


            while (campoMinado.JogoStatus == campoMinado.JogoStatus)
            {
                Console.WriteLine("Digite a linha (1 á 9):");
                int linha = int.Parse(Console.ReadLine());
                while (linha > 9)
                {
                    Console.WriteLine("Fora do tabuleiro, tente outra vez: (1 á 9)");
                    linha = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite a coluna (1 á 9):");
                int coluna = int.Parse(Console.ReadLine());
                while (coluna > 9)
                {
                    Console.WriteLine("Fora do tabuleiro, tente outra vez: (1 á 9)");
                    coluna = int.Parse(Console.ReadLine());
                }

                //ABRE POSIÇÃO
                campoMinado.Abrir(linha, coluna);
                Console.Clear();
                Console.WriteLine("Início do jogo\n=========");
                Console.WriteLine($"{campoMinado.Tabuleiro}\n");

                //DEFINE STATUS DA JOGADA
                //Aberto,
                //Vitoria,
                //GameOver               

                if (campoMinado.JogoStatus == 0)
                {
                    Console.WriteLine("Campo aberto, continue:");
                }
                else if (campoMinado.JogoStatus == 1)
                {
                    Console.WriteLine("========VITÓRIA========");
                    break;
                }
                else if (campoMinado.JogoStatus == 2)
                {
                    Console.WriteLine("========BOOOM!!========");
                    Console.WriteLine("=VOCE ACHOU UMA BOMBA!=");
                    Console.WriteLine("======FIM DE JOGO======");
                    break;
                }
            }
        }
    }
}
