using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semenar1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine("Задание 1:");
            int Number1, Number2;
            Console.Write("Число 1 = ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2 = ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            if (Number1 > Number2)
                Console.WriteLine("max -> " + Number1 + " min -> " + Number2);
            else
                Console.WriteLine("max -> " + Number2 + " min -> " + Number1);
            Console.WriteLine();

            // Задание 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            Console.WriteLine("Задание 2:");
            int[] mas = new int[3];
            for (int i = 0; i<3; i++)
            {
                Console.Write("Число " + (i+1) + " = ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = mas[0];
            for (int i = 1; i < 3; i++)
                if (max < mas[i])
                    max = mas[i];
            Console.WriteLine("max -> " + max);
            Console.WriteLine();

            //Задание 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            Console.WriteLine("Задание 3:");
            Console.Write("Введите число ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число нечетное");
            Console.WriteLine();

            //Задание 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
            Console.WriteLine("Задание 4:");
            Console.Write("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
                if (i % 2 == 0)
                    Console.Write(i + "; ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
