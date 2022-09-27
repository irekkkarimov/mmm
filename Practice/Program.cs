using System;
using practice;
using static Program;

public class Program
{
    static void Main(string[] args)
    {
        // Вызвать нужный метод
        SD();
    }

    static double eq_with_expon()
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

        return s;
    }


    static double cos_with_expon()
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

        return s;
    }


    static double sin()
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

        return s;
    }


    static double Sqrts()
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

        return s;
    }

    public static void GCD()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        for (int i = Math.Max(a, b); i >= 1; i--)
        {
            int result = 0;
            if ((a % i == 0) && (b % i == 0))
            {
                Console.WriteLine($"The GCD is {i}");
                break;
            }
        }
    }

    public static void LCM()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = 2; i <= Math.Max(a, b); i++)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                Console.WriteLine($"The LCM is {i}");
                break;
            }
        }
    }

    public static void SD()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("=== Result ===");
        for (int i = N; i > 1; i--)
        {
            int counter = 0;
            for (int e = i; e > 1; e--)
            {
                if ((i % e) == 0)
                {
                    counter = counter + 1;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}