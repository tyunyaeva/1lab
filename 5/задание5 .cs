using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000;
            int summa = 0;

            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summa += i;
                }
            }
            Console.WriteLine($"Полученная сумма: {summa}");
        }
    }
}
