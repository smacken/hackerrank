using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Min dist pi");

            string[] tokens_min = Console.ReadLine().Split(' ');
            long min = Convert.ToInt64(tokens_min[0]);
            long max = Convert.ToInt64(tokens_min[1]);

            if(min < 1 || min > (long)Math.Pow(10, 15))
                throw new ArgumentException("min");
            if(max < 1 || max < min || max > (long)Math.Pow(10, 15))
                throw new ArgumentException("Max");

            var minDist = new Tuple<long, long, double>(0, 0, double.MaxValue);
            for (var d = min; d <= max; d++){
                long lower = (long)Math.Floor(Math.PI * d);
                long upper = (long)Math.Ceiling(Math.PI * d);
                for (long n = lower; n <= upper; n++){
                    var distance = Math.Abs(Convert.ToDouble((double)n/d) - Math.PI);
                    if(distance <= minDist.Item3){
                        if(distance != minDist.Item3){
                            minDist = new Tuple<long, long, double>(n, d, distance);
                        } else if(minDist.Item2 > d){
                            minDist = new Tuple<long, long, double>(n, d, distance);
                        }                    
                    } 
                }
            }
            Console.WriteLine($"{minDist.Item1}/{minDist.Item2}");
        }
    }
}
