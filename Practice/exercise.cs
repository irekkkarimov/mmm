namespace practice;

public class exercise
{
    public static void ex2()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if ((x >= -1) && (x <= 1))
        {
            if (y >= 0)
            {
                if ((Math.Abs(x) + Math.Abs(y)) == 1)
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
            else
            {
                if ((y < 0) && (y >= -(x * x)))
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}