using final2;
using System;

public class Program
{
    static ILogger logger { get; set; }
    public static void Main(string[] args)
    {
        logger  = new Logger();
        Calc calc = new Calc(logger);
        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = Double.Parse(Console.ReadLine());
                calc.Sum(a, b);
                Console.Write("Введите стоп, чтобы выйти: ");
                string s = Console.ReadLine();
                if (s == "стоп")
                {
                    break;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }



        }
    }
}




