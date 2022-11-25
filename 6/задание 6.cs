using System;

namespace L1T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника");

            string str1 = Console.ReadLine();
            double.TryParse(str1, out double side1);
            string str2 = Console.ReadLine();
            double.TryParse(str2, out double side2);
            string str3 = Console.ReadLine();
            double.TryParse(str3, out double side3);

            if (side1 < side2 + side3 && side2 < side1 + side3
                && side3 < side2 + side1)
            {
                double halfperim = (side1 + side2 + side3) / 2;
                double Square = Math.Sqrt(halfperim * (halfperim - side1) *
                    (halfperim - side2) * (halfperim - side3));

                Console.WriteLine($"Площадь треуголника {Square}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}
