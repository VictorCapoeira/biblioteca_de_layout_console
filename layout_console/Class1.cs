using System;
namespace layout_console{
    public class LayoutWriteLine{
        public static void Vermelho(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Amarelo(string texto){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Azul(string texto){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Verde(string texto){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Cinza(string texto){
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Preto(string texto){
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
    public class LayoutWrite{
        public static void Vermelho(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Amarelo(string texto){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Azul(string texto){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Verde(string texto){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Cinza(string texto){
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(texto);
            Console.ResetColor();
        }
        public static void Preto(string texto){
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(texto);
            Console.ResetColor();
        }
    }
    public class LayoutLinha{
        public static void Completa(){
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
        public static void Meia(){
            Console.WriteLine(new string('-', Console.WindowWidth / 2));
        }
    }
    public class LayoutPosicao{
        public static void Centralizar(string texto){
            Console.WriteLine(new string(' ', Console.WindowWidth / 2) + texto);
        }
    }
}