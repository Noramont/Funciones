using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for(int fila=1; fila<=7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
