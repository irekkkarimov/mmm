using System.ComponentModel;

namespace Practice;

public class lesson
{
    public static void ex1()
    {
        double y = double.Parse(Console.ReadLine());
        double eps = 0.001;
        int k = 0;
        while (y >= eps)
        {
            y = Math.Sin(y);
            k++;
        }
        Console.WriteLine(eps);
        Console.WriteLine(k);
    }

    // public static void ex2()
    // {
    //     double y = 1;
    //     var eps = 0.01;
    //     int k;
    //     double i = 99999;
    //     double x = double.Parse(Console.ReadLine());
    //
    //     while (i >= eps)
    //     {
    //         double s = (Math.Pow(x, k)) / factorial()
    //     }
    //
    // }

    // public static double factorial(int a)
    // {
    //     double res = 1;
    //     for (int i = 1; i <= a; i++)
    //     {
    //         res = res * i;
    //         return res;
    //     }
    // }

//     public static double CR1()
//     {
//         double eps = double.Parse(Console.ReadLine());
//         
//     }
}