using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, op;
            do
            {
                Console.Clear();
                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese elsegundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n1_ Sumar.");
                Console.WriteLine("2_ Restar.");
                Console.WriteLine("3_ Multiplicar.");
                Console.WriteLine("4_ Dividir.");
                Console.WriteLine("5_ Salir.");
                Console.Write("\n¿Qué desea hacer con los números ingresados?: ");
                op = Convert.ToInt32(Console.ReadLine());
                while (op < 1 || op > 5)
                {
                    Console.Write("Ha elegido una opción inexistente. Vuelva a elegirla: ");
                    op = Convert.ToInt32(Console.ReadLine());
                }
                switch (op)
                {
                    case 1:
                        Console.Write("\nLa suma de los dos números es: " + Sumar(num1, num2));
                        break;
                    case 2:
                        Console.Write("\nLa resta de los dos números es: " + Restar(num1, num2));
                        break;
                    case 3:
                        Console.Write("\nLa multiplicación de los dos números es: " + Multiplicar(num1, num2));
                        break;
                    case 4:
                        Console.Write("\nLa división de los dos números es: " + Dividir(num1, num2));
                        break;
                }
                if (op != 5)
                {
                    Console.WriteLine("\n\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (op != 5);
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Dividir(int num1, int num2)
        {
            if (num2 != 0)
                return (double)num1 / num2;
            else
                return 0;
        }

    }
}
