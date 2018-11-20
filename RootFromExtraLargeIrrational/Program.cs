using System;
public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int rootOfFirstMultiplier = 1;
        if (Math.Sqrt(number)%2==1 || Math.Sqrt(number)%2==0)
        {
            Console.WriteLine("Square Root is " + Math.Sqrt(number));
            Console.ReadKey();
        }
        else
        {
            int count = 0;
            int ArrayIterator = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] divisors = new int[count];
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors[ArrayIterator] = i;
                    ArrayIterator++;
                }
            }
            rootOfFirstMultiplier = RootOfFirstMultiplier(divisors);
            int secondMultiplier = number / rootOfFirstMultiplier;
            Console.WriteLine(Math.Sqrt(rootOfFirstMultiplier) + "\u221A" + secondMultiplier);
            Console.ReadKey();
        }
    }
    public static int RootOfFirstMultiplier(int[] divisors)
    {
        int rootFromFirstMultiplier=0;
        for (int i = divisors.Length - 1; i >= 0; i--)
        {
            if (i == divisors.Length - 1)
            {
                continue;
            }
            else
            {
                if (Math.Sqrt(divisors[i]) % 2 == 1 || Math.Sqrt(divisors[i]) % 2 == 0)
                {
                    rootFromFirstMultiplier = divisors[i];
                    break;
                }
            }
        }
        return rootFromFirstMultiplier;
    }
}