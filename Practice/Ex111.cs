namespace practice;

public class Ex111
{
    public static double Solution(double x, double a, double eps)
    {
        double result = 0;
        int k = 0;
        int fact = 0;
        while (result < eps)
        {
            if (k == 0)
            {
                fact = 1;
                result += ((Math.Pow(-1 + a, k) * x * Math.Pow((Math.Log(x, 10)), k)) / fact);
                ;
            }
            else
            {
                fact = fact * k;
                result += ((Math.Pow(-1 + a, k) * x * Math.Pow((Math.Log(x, 10)), k)) / fact);
            }
        }

        return result;
    }
}

//     public static double Sum(double x, double a, double eps)
//     {
//         double result = 0;
//         var i = 0;
//         int fact = 0;
//         while (result < eps)
//         {
//             if (i != 0)
//             {
//                 fact = fact * i;
//                 double res = Solution(x, a, i, fact);
//                 result += res;
//                 i++;
//             }
//             else
//             {
//                 fact = 1;
//                 double res = Solution(x, a, i, 1);
//                 result += res;
//                 i++;
//             }
//         }
//
//         return result;
//     }
// }