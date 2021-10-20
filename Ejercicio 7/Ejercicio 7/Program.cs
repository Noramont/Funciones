using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            char letra;
            Console.Write("Ingrese el ancho que tendrá el triángulo: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la letra: ");
            letra = Console.ReadLine()[0];
            triángulo(letra, ancho);
            Console.ReadKey();
        }

        public static void triángulo(char letra, int ancho)
        {
            Console.Write("\n\n");
            for(int i = ancho; i>0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(letra);
                Console.WriteLine();
            }
            return;
        }

    }
}
