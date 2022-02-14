using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!


            Console.SetCursorPosition(0, 2);
            int cursorX = 1;
            int cursorY = 1;

            ConsoleKeyInfo pressioneTecla;
            do
            {
                pressioneTecla = Console.ReadKey(true);
                switch (pressioneTecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cursorY > 2)
                        {
                            cursorY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursorY < 10)
                        {
                            cursorY++;
                        }
                        break; 
                    case ConsoleKey.RightArrow:
                        if (cursorX < 8)
                        {
                            cursorX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (cursorX > 0)
                        {
                            cursorX--;
                        }
                        break;

                    default:
                        break;
                }
                Console.SetCursorPosition(cursorX, cursorY);
            }
            while (pressioneTecla.Key != ConsoleKey.Enter);
        }
    }
}
