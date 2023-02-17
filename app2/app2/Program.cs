using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            //(-1)^n * x^2n+1 / (2n+1)
            Console.WriteLine("Функция: (-1)^n * x^2n+1 / (2n+1)");
            Console.WriteLine("n>-1, n= ");
            double n = Convert.ToDouble(Console.ReadLine());
            while (n<0)
            {
                Console.WriteLine("Некорректное число, повторите n= ");
                n = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("lxl <= 1, x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            while (x>1 && x <-1)
            {
                Console.WriteLine("Некорректное число, повторите x= ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            double sum = 0;
            for (double i = 0; i < n-1; i++)
            {
                sum += (Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (2 * n + 1);
            }
            Console.Write(2 * sum);
        }
    }
}
