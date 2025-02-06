using System;
namespace layout_console{
    public class LayoutWriteLine{
        public static void Vermelho(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}