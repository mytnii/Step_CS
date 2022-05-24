/*
   Даны целые положительные числа A, B, C.
   Значение этих чисел программа должна запрашивать у пользователя. 
   На прямоугольнике размера A*B размещено максимально 
   возможное количество квадратов со стороной C. 
   Квадраты не накладываются друг на друга. 
   Найти количество квадратов, размещенных на прямоугольнике, 
   а также площадь незанятой части прямоугольника. 
   Необходимо предусмотреть служебные сообщения в случае, 
   если в прямоугольнике нельзя разместить ни одного квадрата со стороной С 
   (например, если значение С превышает размер сторон прямоугольника).
 */
using System;
namespace NumberOfSquares
{
    public class Program
    {
        static void Main(string[] args)
        {
            int A = NumberEntru();
            if (A <= 0)
            {
                Console.WriteLine("Неправельный ввод числа");
                return;
            }

            int B = NumberEntru();
            if(B <= 0)
            {
                Console.WriteLine("Неправельный ввод числа");
                return;
            }

            int C = NumberEntru();
            if(C <= 0)
            {
                Console.WriteLine("Неправельный ввод числа");
                return;
            }

            if(C > A || C > B)
            {
                Console.WriteLine("В прямоугольнике нельзя разместить ни одного квадрата");
                return;
            }

            int numberOfSquares = (A / C) * (B / C);
            Console.WriteLine($"Квадратов в прямоугольнике {numberOfSquares}");
        }

        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <returns></returns>
        static int NumberEntru()
        {
            Console.WriteLine("Введите целое число");
           int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }
}