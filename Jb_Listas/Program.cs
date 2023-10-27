using System;

namespace JB_Listas
{
    public class Program
    {
        static void Main(string[] args)
        {
         Console.ForegroundColor = ConsoleColor.Yellow;
         Lista l = new Lista();
         l.Insertnodo();
         l.Insertnodo();
         l.Insertnodo();
         l.Insertnodo();
         l.Insertnodo();
         Console.WriteLine("La lista de los Nodos es:");
         l.PrintList();
         Console.ReadKey();
        }
    }
}
