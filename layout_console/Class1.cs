using System;
using System.Collections.Generic;
namespace Layout_console
{


    public class LayoutWriteLine
    {
        public static void Vermelho(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Amarelo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Azul(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Verde(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Cinza(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Preto(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
    public class LayoutWrite
    {
        public static void Vermelho(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Amarelo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Azul(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Verde(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Cinza(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Preto(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(texto);
            Console.ResetColor();
        }
    }
    public class LayoutLinha
    {
        private static readonly Dictionary<string, ConsoleColor> cores = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
        {
            { "red", ConsoleColor.Red }, { "vermelho", ConsoleColor.Red },
            { "yellow", ConsoleColor.Yellow }, { "amarelo", ConsoleColor.Yellow },
            { "blue", ConsoleColor.Blue }, { "azul", ConsoleColor.Blue },
            { "green", ConsoleColor.Green }, { "verde", ConsoleColor.Green },
            { "gray", ConsoleColor.Gray }, { "cinza", ConsoleColor.Gray },
            { "black", ConsoleColor.Black }, { "preto", ConsoleColor.Black },
            { "white", ConsoleColor.White }, { "branco", ConsoleColor.White }
        };
        public static void Completa(string cor = " ")
        {
            cor = cor.ToLower();
            if (cores.TryGetValue(cor, out ConsoleColor corConsole))
            {
                Console.ForegroundColor = corConsole;
            }
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ResetColor();
        }
        public static void Meia(string cor = " ")
        {
            cor = cor.ToLower();
            if (cores.TryGetValue(cor, out ConsoleColor corConsole))
            {
                Console.ForegroundColor = corConsole;
            }
            Console.WriteLine(new string('-', Console.WindowWidth / 2));
            Console.ResetColor();


        }
    }
    public class LayoutPosicao
    {
        private static readonly Dictionary<string, ConsoleColor> cores = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
        {
            { "red", ConsoleColor.Red }, { "vermelho", ConsoleColor.Red },
            { "yellow", ConsoleColor.Yellow }, { "amarelo", ConsoleColor.Yellow },
            { "blue", ConsoleColor.Blue }, { "azul", ConsoleColor.Blue },
            { "green", ConsoleColor.Green }, { "verde", ConsoleColor.Green },
            { "gray", ConsoleColor.Gray }, { "cinza", ConsoleColor.Gray },
            { "black", ConsoleColor.Black }, { "preto", ConsoleColor.Black },
            { "white", ConsoleColor.White }, { "branco", ConsoleColor.White }
        };
        public static void Centralizar(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            if (cores.TryGetValue(cor, out ConsoleColor corConsole))
            {
                Console.ForegroundColor = corConsole;
            }
            Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
            Console.ResetColor();
        }
        public static void CentralizarLinha(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            if (cores.TryGetValue(cor, out ConsoleColor corConsole))
            {
                Console.ForegroundColor = corConsole;
            }
            Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
            Console.ResetColor();
        }

        public static void Esquerda(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            if (cores.TryGetValue(cor, out ConsoleColor corConsole))
            {
                Console.ForegroundColor = corConsole;
            }
            Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
            Console.ResetColor();
        }
    }
    public class LayoutCabecalho
    {
        public static void Minimalista(string titulo)
        {

            Console.WriteLine(new string('=', titulo.Length + 6)); // Linha superior
            Console.WriteLine($"== {titulo} ==");                 // Texto centralizado
            Console.WriteLine(new string('=', titulo.Length + 6)); // Linha inferior
        }
        public static void Estiloso(string titulo)
        {
            Console.WriteLine("╔════════════════════╗");
            Console.WriteLine($"║  {titulo.PadRight(16)}║");
            Console.WriteLine("╚════════════════════╝");
        }
    }
}