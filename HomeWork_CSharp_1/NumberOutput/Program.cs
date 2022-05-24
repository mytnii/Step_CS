/*
   Даны целые положительные числа A и B (A < B). 
   Вывести все целые числа от A до B включительно; 
   каждое число должно выводиться на новой строке; 
   при этом каждое число должно выводиться количество раз, 
   равное его значению (например, число 3 выводится 3 раза). 
   Например: если А = 3, а В = 7, 
   то программа должна сформировать в консоли следующий вывод: 
   3 3 3 4 4 4 4 5 5 5 5 5 6 6 6 6 6 6 7 7 7 7 7 7 7
 */

using System;

namespace NumberOutput
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            string? str = Console.ReadLine();
            int A;
            int B;

                int.TryParse(str, out A);
                if(A == 0 && str != "0")
                {
                    Console.WriteLine("Неправыельный ввод первого числа");
                    return;
                }

                Console.WriteLine("Введите второе число");
                Console.WriteLine("Второе число не должно быть меньше первого");

                str = Console.ReadLine();
                int.TryParse(str, out B);
                if(B == 0 || B < A)
                {
                    Console.WriteLine("Неправельный ввод второго числа");
                    return;
                }

            int[][] matrix = new int[B - A + 1][];

            int number = A;

           for(int i = 0; i < B - A + 1; i++)
            {
                matrix[i] = new int[number];
                ++number;
            }

            number = A;

           for(int i = 0; i < matrix.Length; ++i)
            {
                for(int j = 0; j < matrix[i].Length; ++j)
                {
                    matrix[i][j] = number;
                }

                ++number;
            }

           for(int i = 0; i < matrix.Length; ++i)
            {
                for(int j = 0; j < matrix[i].Length; ++j)
                {
                    Console.Write($"{matrix[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}