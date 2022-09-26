using System;
using practice;

public class Program
{
    static void Main(string[] args)
    {
        // Вызвать нужный метод
        exercise.ex2();
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
    
}