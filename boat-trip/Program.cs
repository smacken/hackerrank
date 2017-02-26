using System;

namespace ConsoleApplication
{
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Boat Trip");

            int[] input = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(x => int.Parse(x))
                .Take(3)
                .ToArray();
            int n = input[0];
            int c = input[1];
            int m = input[2];
            Func<int, bool> isValidInput = (value) => { return value > 0 && value <= 100; };
            if(!isValidInput(n) || !isValidInput(c) || !isValidInput(m))
                throw new ArgumentException("input");
            int[] p = Console.ReadLine().Trim()
                .Split(' ')
                .Select(x => int.Parse(x))
                .Take(n)
                .ToArray();
            // if(p.Any(x => x < 1 || x > 100)){
            //     Console.WriteLine("No");
            //     return;
            // }
            Console.WriteLine(p.All(x => x <= c*m) ? "Yes" : "No");
        }
    }
}
