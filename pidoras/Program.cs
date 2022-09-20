using System;

public class Program
{
    static void Main(string[] args)
    {
        static void eq_with_expon()
        {
            double x = double.Parse(Console.ReadLine());
            double s = 0;
            int i = 10;
            double p = 1;
            while (i > 0)
            {
                s = s + i * p;
                p = p * x;
                i--;
            }

            Console.WriteLine(s);
        }


        static void cos_with_expon()
        {
            double x = double.Parse(Console.ReadLine());
            int i = 1;
            double s = 0;
            double p = 1;

            while (i < 11)
            {
                p = p * x;
                s = s + Math.Cos(x);
                i++;
            }

            Console.WriteLine(s);
        }


        static void sin()
        {
            double x = double.Parse(Console.ReadLine());
            int k;
            k = int.Parse(Console.ReadLine());
            double s = 0;
            double p = 1;
            int i = 0;

            while (i < k)
            {
                s = s + p * Math.Sin(x);
                p = p * Math.Sin(x);
                i++;
            }

            Console.WriteLine(s);
        }


        static void Sqrts()
        {
            int i = 99;
            double s = 0;
            double p = 0;
            double n = 0;

            while (i > 0)
            {
                p = Math.Sqrt(p + i);
                s = s + p;
                i = i - 3;
            }

            Console.WriteLine(s);
        }
    }
}