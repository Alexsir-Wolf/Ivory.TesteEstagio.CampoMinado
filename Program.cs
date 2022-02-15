using System;
using static Ivory.TesteEstagio.CampoMinado.CampoMinado;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            //Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            while (campoMinado.JogoStatus == (int)StatusTipo.Aberto)
            {
                Console.WriteLine("Digite a linha (1 á 9):");
                int linha = int.Parse(Console.ReadLine());
                if(linha > 9)
                {
                    Console.WriteLine("Fora do tabuleiro, tente outra vez: (1 á 9)");
                    linha = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite a coluna (1 á 9):");
                int coluna = int.Parse(Console.ReadLine());
                if (coluna > 9)
                {
                    Console.WriteLine("Fora do tabuleiro, tente outra vez: (1 á 9)");
                    coluna = int.Parse(Console.ReadLine());
                }

                campoMinado.Abrir(linha, coluna);
                Console.Clear();
                Console.WriteLine(campoMinado.Tabuleiro);

                if(campoMinado.JogoStatus == (int)StatusTipo.Aberto)
                {
                    Console.WriteLine("Campo aberto, continue:");
                }
                if (campoMinado.JogoStatus == (int)StatusTipo.Vitoria)
                {
                    Console.WriteLine("========VITÓRIA========");
                }                    
                if (campoMinado.JogoStatus == (int)StatusTipo.GameOver)
                {
                    Console.WriteLine("========BOOOM!!========");
                    Console.WriteLine("=VOCE ACHOU UMA BOMBA!=");
                    Console.WriteLine("======FIM DE JOGO======");
                }
                    
            }
        }
    }
}
