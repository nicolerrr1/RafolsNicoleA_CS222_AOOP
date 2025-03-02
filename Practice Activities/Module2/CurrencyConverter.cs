using System;

public class CurrencyConverter
{
    public static void Main(string[] args){
       Console.Write("Enter amount in USD: ");
       double dollar = double.Parse(Console.ReadLine());
       
       Console.Write("Enter exchange rate from USD to EUR: " );
       double rate = double.Parse(Console.ReadLine());
       
       double euro = (dollar * rate);
       Console.Write("Amount in EUR: " +euro);
    }
}