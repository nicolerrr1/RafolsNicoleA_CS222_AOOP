using System;

public class SkipRowPattern
{
    public static void Main(string[] args)
    {

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == y) 
                continue;

            Console.WriteLine(new string('*', n)); 
        }
    }
}
