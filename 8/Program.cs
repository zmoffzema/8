using System;

public class Program
{
    public static void Main()
    {
        int number = 29;
        bool isPrime = IsPrime(number);
        Console.WriteLine("Is the number " + number + " prime? " + isPrime);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}