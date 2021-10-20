using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (esPrimo(num))
                Console.Write("\nEste número es primo.");
            else
                Console.Write("\nEste número no es primo.");
            Console.ReadKey();
        }

        public static bool esPrimo(int num)
        {
            if (num % 2 == 0 && num != 2)
                return false;
            else if (num == 2)
                return true;
            else
            {
                for (int i = 3; i <= num / 2; i = i + 2)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
