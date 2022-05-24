/*
   Начальный вклад в банке равен 10000 руб. 
   Через каждый месяц размер вклада увеличивается
   на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). 
   Значение Р программа должна получать у пользователя. 
   По данному P определить через сколько месяцев размер вклада превысит 11000 руб., 
   и вывести найденное количество месяцев K (целое число) 
   и итоговый размер вклада S (вещественное число).
 */
using System;
namespace BankDeposit
{
    public class Program
    {
        static void Main(string[] args)
        {
            double initialContribution = 10000.0;  //Начальный депозит   

            Console.WriteLine("Введите процен начисляемый каждый мецяс");
            Console.WriteLine("Процент должен быть больше 0 и меньше 25");

            double interest = Convert.ToDouble(Console.ReadLine());

            int month = 0;

            while(initialContribution <= 11000)
            {
                ++month;
                initialContribution += (initialContribution / 100) * interest;
            }

            Console.WriteLine($"Через {month} месяцев вклад привысит 11000");
            Console.WriteLine($"Итоговый размер вклада: {initialContribution}");
        }
    }
}