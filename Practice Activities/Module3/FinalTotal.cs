using System;

public class FinalTotal
{
    public static void Main(string[] args)
    {
        int total = 10;
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            if (num % 2 == 0)
            {
                total += (num * num);
                Console.WriteLine("The number is even.");
            }
            else
            {
                total += (num * num * num);
                Console.WriteLine("The number is odd.");
            }
            Console.WriteLine(total); 
        }
        else if (num < 0)
        {
            Console.Write("Enter another integer: ");
            int exponent = int.Parse(Console.ReadLine()); 

            long powerResult = (long)Math.Pow(num, exponent); 
            Console.WriteLine(powerResult); 
        }
        else {
            Console.WriteLine("Nothing happened.");
        }
    }
}
