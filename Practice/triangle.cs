namespace practice;

public class triangle
{
    public static void o4po4mak()
    {
        int s = int.Parse(Console.ReadLine());

        for (int i = 0; i >= s;) ;
    }
    
    public static int[] GetPoweredArray(int[] arr, int power)
    {
        int[] res = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            int tRes = arr[i];
            for (int e = 1; e <= power; e++)
            {
                tRes = tRes * tRes;
            }

            res[i] = tRes;
        }
        return res;
    }

}