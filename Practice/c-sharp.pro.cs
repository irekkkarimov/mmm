namespace practice;

public class exercises
{
    public static void pr()
    {
        int a = 543;
        int b = 130;
        var res = a / 130;
        Console.WriteLine(res);
    }

    public static void week()
    {
        int k = int.Parse(Console.ReadLine());

        string[] alphabet =
            { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        for (int i = 7; i >= 1; i--)
        {
            if ((k % i) == 0)
            {
                if ((i % 7) == 0)
                {
                    Console.WriteLine(alphabet[0]);
                    break;
                }
                else
                {
                    Console.WriteLine(alphabet[i - 1]);
                    break;
                }
            }
        }
        
    }


    
    public static string GetGreetingMessage(string name, double salary)
    {
        string result = $"Hello, {name}, your salary is {salary}";
        return result;
    }
    
}