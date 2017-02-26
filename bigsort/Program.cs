using System;

namespace ConsoleApplication
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Numerics;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Big sort");

            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger[] unsorted = new BigInteger[n];
            for(int unsorted_i = 0; unsorted_i < n; unsorted_i++)
                unsorted[unsorted_i] = BigInteger.Parse(Console.ReadLine());
            
            var sorted = unsorted.ToList();
            sorted.Sort();
            sorted.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
