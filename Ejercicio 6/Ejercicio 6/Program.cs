using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nLa suma de sus dígitos es: " + sumaCifras(num));
            Console.ReadKey();
        }

        public static int sumaCifras(int número)
        {
            int suma = 0;
            while (número > 10)
            {
                suma = suma + número % 10;
                número = número / 10;
            }
            return suma += número;
        }
    }
}
