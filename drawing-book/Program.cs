using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Drawing book");

            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            if(n <= 0 || n > Math.Pow(10, 5)) throw new ArgumentException("n is incorrect");
            if(p > n || p <= 0) throw new ArgumentException("p is incorrect");
            int closest = Math.Min(p, n-p);
            int pagesTurned = (closest/2);
            Console.WriteLine("\nOutput");
            Console.WriteLine(pagesTurned);

        }
    }
}
