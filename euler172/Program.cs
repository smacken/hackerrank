
namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static int CountSubstring(string text, string value)
        {                  
            int count = 0, minIndex = text.IndexOf(value, 0);
            while (minIndex != -1)
            {
                minIndex = text.IndexOf(value, minIndex + value.Length);
                count++;
            }
            return count;
        }

        static int Occurance(int number, int digit){
            var n = number;
            var i = 0;
            int k;
            while(n != 0){
                k = n % 10;
                n = n / 10;
                if(k == digit)i++;
            }
            return i;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Euler 172");
            var firstInput = Console.ReadLine()
                .Trim().Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToList();
            int m = firstInput[0];
            int t = firstInput[1];
            var k = new int[t];
            for (int i = 0; i < t; i++)
                k[i] = Convert.ToInt32(Console.ReadLine());

            // constraints
            if(m < 1 || m > Math.Pow(10, 5))
                throw new ArgumentException("m");
            if(t < 1 || t > Math.Pow(10, 5))
                throw new ArgumentException("t");
            if(k.Any(x => x < 1 || x > Math.Min(10*x, Math.Pow(10, 5))))
                throw new ArgumentException("k");

            var moduloValue = Math.Pow(10, 9) + 7;
            // each query
            foreach (var item in k)
            {
                int allowed = 0;
                // each possible number
                string number = string.Empty;
                for (int i = 1; i < Math.Pow(10, item); i++){
                    int numLength = (int)Math.Floor(Math.Log10(i)) + 1;
                    if(numLength < item) continue;
                    var topMatches = 0;
                    for (int d = 0; d < 10; d++)
                    {
                        int matches = Occurance(i, d);
                        if(matches > topMatches) topMatches = matches;
                    }
                    if(topMatches <= m) allowed++;
                }
                Console.WriteLine(allowed % moduloValue);
                allowed = 0;
                number = string.Empty;
            }
        }
    }
}
