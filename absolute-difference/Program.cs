using System;
using System.Linq;

namespace ConsoleApplication
{
    // https://www.hackerrank.com/contests/rookierank-2/challenges/minimum-absolute-difference-in-an-array
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Absolute difference array");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 2 || n > Math.Pow(10, 5))
                throw new ArgumentException("Invalid n");
            string[] a_temp = Console.ReadLine().Trim().Split(' ');
            int[] a = a_temp.Select(x => Convert.ToInt32(x)).ToArray();
            if(a.Any(item => item < -Math.Pow(10, 9) || item > Math.Pow(10, 9)))
                throw new ArgumentException("Invalid a");
            int lowest = (int) Math.Pow(10, 9);
            for (int i = 0; i < a.Count(); i++){
                for (int y = 0; y < a.Count(); y++){
                    if(a[y] == a[i]) continue;
                    var diff = Math.Abs(a[i] - a[y]);                    
                    if (diff < lowest) lowest = diff;
                }
            }
            Console.WriteLine(lowest);
        }
    }
}
