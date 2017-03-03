using System;
using System.Linq;

namespace ConsoleApplication
{
    // https://www.hackerrank.com/contests/hourrank-18/challenges/wheres-the-marble
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where The marble");

            var input = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            int m = input[0];
            int n = input[1];
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++){
               var saucers = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
               a[i] = saucers[0];
               b[i] = saucers[1]; 
            }
            // a.ToList().ForEach(Console.WriteLine);
            // b.ToList().ForEach(Console.WriteLine);

            // constraints
            if(m < 1 || m > 10)
                throw new ArgumentException("m");
            if(n < 1 || n > 50)
                throw new ArgumentException("n");
            if(a.Any(x => x < 1 || x > 10))
                throw new ArgumentException("a");
            if(b.Any(x => x < 1 || x > 10))
                throw new ArgumentException("b");

            for (int i = 0; i < n; i++){
                if(a[i] != m && b[i] != m) continue;
                if(a[i] == m) 
                    m = b[i];
                else if(b[i] == m) 
                    m = a[i];
            }
            Console.WriteLine(m);
        }
    }
}
