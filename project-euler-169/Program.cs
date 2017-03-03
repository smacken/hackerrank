using System;

namespace ConsoleApplication
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    // https://www.hackerrank.com/contests/projecteuler/challenges/euler169
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Project Euler 169");

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            List<BigInteger> powers = new List<BigInteger>(){1, 1};
            for (int i = 1; BigInteger.Pow(2, i) <= n; i++) {
                var p = BigInteger.Pow(2, i);
                powers.Add(p);
                powers.Add(p);
            }
            var combinations = GetCombinations(powers.ToArray(), n, string.Empty).Distinct();
            // combinations.ToList().ForEach(Console.WriteLine);
            Console.WriteLine(combinations.Count());
        }

        public static IEnumerable<string> GetCombinations(BigInteger[] powers, BigInteger sum, string values){
            for (int i = 0; i < powers.Length; i++){
                var left = sum - powers[i];
                string value = powers[i] + " " + values;
                if(left == 0) yield return value;
                BigInteger[] combinations = powers.Take(i).Where(x => x <= sum).ToArray();
                if(combinations.Length > 0){
                    foreach(var combo in GetCombinations(combinations, left, value))
                        yield return combo;
                }
            }
        }
    }
}
