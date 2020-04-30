using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insira uma temperatura em Fahrenheit e veja a mesma em Celsius.");
            Console.ForegroundColor = ConsoleColor.Blue;
            string f = Console.ReadLine();
            decimal f1 = Convert.ToDecimal(f);

            string um = "1,8";
            decimal um1 = Convert.ToDecimal(um);
            decimal result1 = f1 - 32;
            decimal resultfinal = result1 / um1;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seu resultado em Celsius é " + resultfinal + "°C.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
