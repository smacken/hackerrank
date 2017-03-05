using System;
using System.Numerics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Super Six substrings");

            string s = Console.ReadLine().Trim();
            int substrings = 0;

            if(s.Length < 1 || s.Length > (int)Math.Pow(10, 5)) 
                throw new ArgumentException("s");
            BigInteger numeric;
            if(!BigInteger.TryParse(s, out numeric)) 
                throw new ArgumentException("s");
            
            for (int i = 0; i < s.Length; i++) {
                if(s[i] == '0'){
                    substrings++;
                    continue;
                }
                int sub = 1;
                while (sub <= s.Length-i)
                {
                    var numeral = BigInteger.Parse(s.Substring(i, sub));
                    if(numeral % 6 == 0) substrings++;
                    sub++;
                }
            }
            Console.WriteLine(substrings);
        }
    }
}
