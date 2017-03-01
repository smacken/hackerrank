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
                .Take(n);

            // constraints
            if(n < 1 || n > (int)Math.Pow(10, 5)) 
                throw new ArgumentException("n");
            var upperArrBounds = (long)Math.Pow(10, 18);
            if(arr.Any(x => x < 1 || x > upperArrBounds)) 
                throw new ArgumentException("n");

            Func<long, long, bool> isDivisor = (a, b) => { 
                return (Math.Max(a, b) % Math.Min(a, b)) == 0; 
            };

            int commonDivisor = default(int);
            foreach (var num in Enumerable.Range(1, int.MaxValue)){
                var divisorMatches = arr.Count(x => isDivisor(num, x));
                if(divisorMatches == n-1){
                    commonDivisor = num;
                    break;
                }
            }
            Console.WriteLine(commonDivisor);
        }

        public static int Divisor(int a, int b)
        {
            return b == 0 ? a : Divisor(b, a % b);
        }
    }
}
