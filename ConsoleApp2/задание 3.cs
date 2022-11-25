using System;
namespace L1T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            string str = Console.ReadLine();
            int.TryParse(str, out int rowCount);

            int star = 1;

            if (rowCount > 0)
            {
                while (star <= rowCount)
                {
                    for (var i = 1; i <= rowCount - star; i++)
                    {
                        Console.Write(" ");
                    }

                    for (var j = 1; j <= 2 * star - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                    star += 1;
                }
            }
            else
            {
                Console.WriteLine("Введены неверные данные");
            }
        }
    }
}
