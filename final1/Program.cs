using final1;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Calc calc = new Calc();
        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Сумма чисел {a} и {b} = {calc.Sum(a, b)}");
                Console.Write("Введите стоп, чтобы выйти: ");
                string s = Console.ReadLine();
                if (s == "стоп")
                {
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}


