using System;
using System.Linq;

public class PrimeNumbersUsing
{
    public static void Main(string[] args)
    {
        PrimeNumbers primeNumbers = new PrimeNumbers();

        Console.WriteLine("Простые числа до 30:");
        foreach (var prime in primeNumbers.GetPrimes(30))
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Первые 5 простых чисел после пропуска первых 3:");
        foreach (var prime in primeNumbers.SkipPrimes(3).Take(5))
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Первые 10 простых чисел:");
        foreach (var prime in primeNumbers.GetAllPrimes().Take(10))
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine("\n");
    }
}