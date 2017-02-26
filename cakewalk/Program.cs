using System;

namespace ConsoleApplication
{
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cakewalk");
            int n = Convert.ToInt32(Console.ReadLine());
            var cupcakes = Console.ReadLine()
                .Trim().Split(' ')
                .Select(x => Convert.ToInt32(x))
                .OrderByDescending(x => x)
                .Take(n)
                .ToArray();

            if(n < 1 || n > 40)
                throw new ArgumentException("n");
            if( cupcakes.Any(x => x< 1 || x > 1000))
                throw new ArgumentException("c");

            long walk = 0;
            for (int i = 0; i < cupcakes.Count(); i++)
                walk += cupcakes[i]*(long)Math.Pow(2, i);
            
            Console.WriteLine(walk);
        }
    }
}
