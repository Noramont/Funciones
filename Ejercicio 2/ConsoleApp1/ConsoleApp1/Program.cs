using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch(menor(num1, num2))
            {
                case 1:
                    Console.Write("\nEl primer número es mayor al segundo.");
                    break;
                case -1:
                    Console.Write("\nEl segundo número es mayor al primero.");
                    break;
                case 0:
                    Console.Write("\nLos números son iguales.");
                    break;
            }
            Console.ReadKey();
        }

        public static int menor(int num1, int num2)
        {
            if (num1 > num2)
                return 1;
            else if (num1 < num2)
                return -1;
            else
                return 0;
        }
    }
}
