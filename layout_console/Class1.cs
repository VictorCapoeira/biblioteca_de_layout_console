using System;
namespace layout_console
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
        public static void Completa()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
        public static void Meia()
        {
            Console.WriteLine(new string('-', Console.WindowWidth / 2));
        }
    }
    public class LayoutPosicao
    {
        public static void Centralizar(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            switch (cor)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "amarelo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "cinza":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                case "preto":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
                    break;
            }

        }
        public static void CentralizarLinha(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            switch (cor)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "amarelo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "cinza":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                case "preto":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine(new string('-', Console.WindowWidth / 2) + texto + new string('-', Console.WindowWidth / 2 - texto.Length));
                    break;
            }
        }

        public static void Esquerda(string texto, string cor = " ")
        {
            cor = cor.ToLower();
            switch (cor)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "amarelo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "cinza":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                case "preto":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine(new string(' ', Console.WindowWidth - texto.Length) + texto);
                    break;
            }
        }
    }
}