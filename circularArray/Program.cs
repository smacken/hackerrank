using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Circular array");

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            // constraints
            if(n < 1 || n > (int)Math.Pow(10, 5)) throw new ArgumentException("n");
            if(k < 1 || k > (int)Math.Pow(10, 5)) throw new ArgumentException("k");
            if(q < 1 || q > 500) throw new ArgumentException("q");
            if(a.Any(x => x < 1 || x > (int)Math.Pow(10, 5))) throw new ArgumentException("a");
            
            var aQueue = new List<int>(a);
            for (int i = 0; i < k; i++)
            {
                
                var end = aQueue.ElementAt(n-1);
                aQueue.RemoveAt(n-1);
                aQueue.Insert(0, end);
            }
            int[] circular = new int[a.Length];
            aQueue.CopyTo(circular, 0);
            for(int query = 0; query < q; query++){
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(circular[m]);
            }
        }
    }
}
