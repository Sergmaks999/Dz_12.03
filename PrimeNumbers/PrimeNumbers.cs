using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimeNumbers
{
    public IEnumerable<int> GetPrimes(int limit)
    {
        if (limit < 2)
        {
            yield break; 
        }

        yield return 2;

        for (int number = 3; number <= limit; number += 2)
        {
            if (IsPrime(number))
            {
                yield return number;
            }
        }
    }

    public IEnumerable<int> GetAllPrimes()
    {
        int number = 2;
        while (true)
        {
            if (IsPrime(number))
            {
                yield return number;
            }
            number++;
        }
    }

    public IEnumerable<int> SkipPrimes(int count)
    {
        int skipped = 0;
        foreach (var prime in GetAllPrimes())
        {
            if (skipped < count)
            {
                skipped++;
            }
            else
            {
                yield return prime;
            }
        }
    }

    private bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;

        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i = i + 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
}