using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int número;
            Console.Write("Ingrese un número: ");
            número = Convert.ToInt32(Console.ReadLine());
            Console.Write("El número es ");
            if (signo(número) == 1)
                Console.Write("positivo.");
            else if (signo(número) == -1)
                Console.Write("negativo.");
            else
                Console.Write("un cero.");
            Console.ReadKey();
        }

        public static int signo(int num)
        {
            if (num < 0)
                return -1;
            else if (num > 0)
                return 1;
            else
                return 0;
        }
    }
}
