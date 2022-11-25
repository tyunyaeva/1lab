using System;

namespace L1T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников,составляющих ёлку");
            string str = Console.ReadLine();
            int.TryParse(str, out int rowTriangles);
            int star = 1;
            int rowCount = 1;

            if (rowTriangles > 0)
            {
                for (var l = 1; l <= rowTriangles; l++)
                {
                    while (star <= rowCount)
                    {
                        for (var i = 1; i <= rowTriangles - star + 2; i++)
                        {
                            Console.Write(" ");
                        }

                        for (var j = 1; j <= 2 * star - 1; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                        star++;
                    }
                    rowCount++;
                    star = 1;
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}
