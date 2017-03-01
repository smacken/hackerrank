

namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // https://www.hackerrank.com/contests/w29/challenges/megaprime-numbers
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens_first = Console.ReadLine().Split(' ');
            long first = Convert.ToInt64(tokens_first[0]);
            long last = Convert.ToInt64(tokens_first[1]);

            // constraints
            if(first < 1 || first > (long)Math.Pow(10, 15))
                throw new ArgumentException("first");
            if(last < 1 || last > (long)Math.Pow(10, 15))
                throw new ArgumentException("last");
            if(first > last)
                throw new ArgumentException("first greater than last");
            if(last - first > (long)Math.Pow(10, 9)) 
                throw new ArgumentOutOfRangeException("last minus first");

            var digitPrimes = new List<long>(4) {2, 3, 5, 7};
            long megaprimeCount = 0;
            for (var i = first; i <= last; i++){
                if(i != 2 && i % 2 == 0) continue;
                if(i > 7 && GetDigits(i).ToArray().Any(x => digitPrimes.IndexOf(x) < 0)) continue;
                if(!IsPrime(i)) continue;
                if(GetDigits(i).ToArray().All(x => digitPrimes.IndexOf(x) >= 0))
                    megaprimeCount++;
            }
            Console.WriteLine(megaprimeCount);
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var boundary = (long)Math.Floor(Math.Sqrt(number));
            for (long i = 2; i <= boundary; i++)
                if (number % i == 0)  return false;
            
            return true;        
        }

        public static Stack<long> GetDigits(long value)
        {
            if (value == 0) return new Stack<long>();
            var numbers = GetDigits(value / 10);
            numbers.Push(value % 10);
            return numbers;
        }
    }
}
