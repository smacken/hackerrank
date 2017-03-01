using System;

namespace ConsoleApplication
{
    using System.Linq;

    // https://www.hackerrank.com/contests/101hack45/challenges/the-chosen-one
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Chosen one");

            int n = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().Trim()
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToList()
                .Take(n)
                .OrderBy(x => x);

            // constraints
            if(n < 1 || n > (long)Math.Pow(10, 5)) 
                throw new ArgumentException("n");
            var upperArrBounds = (long)Math.Pow(10, 18);
            if(arr.Any(x => x < 1 || x > upperArrBounds)) 
                throw new ArgumentException("n");

            Func<long, long, bool> isDivisor = (a, b) => { return a % b == 0; };

            int commonDivisor = default(int);
            for(var num = 2; num < int.MaxValue; num++){
                int divisorMatches = 0;
                int nonMatch = 0;
                foreach(var i in arr){
                    // try to bail early knowing we need n-1
                    if(nonMatch > 1) break;
                    if(isDivisor(i, num))
                        divisorMatches++;
                    else
                        nonMatch++;
                }
                if(divisorMatches == n-1){
                    commonDivisor = num;
                    break;
                }
            }
            Console.WriteLine(commonDivisor);
        }
    }
}
