

namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    // https://www.hackerrank.com/contests/w29/challenges/megaprime-numbers
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mega prime");

            string[] tokens_first = Console.ReadLine().Split(' ');
            long first = Convert.ToInt64(tokens_first[0]);
            long last = Convert.ToInt64(tokens_first[1]);

            if(long.MaxValue < Math.Pow(10, 15)) throw new ArgumentException("BigInt");

            // constraints
            if(first < 1 || first > (long)Math.Pow(10, 15))
                throw new ArgumentException("first");
            if(last < 1 || last > (long)Math.Pow(10, 15))
                throw new ArgumentException("last");
            if(first > last)
                throw new ArgumentException("first greater than last");
            if(last - first > (long)Math.Pow(10, 9)) 
                throw new ArgumentOutOfRangeException("last minus first");

            long megaprimeCount = 0;
            for (var i = first; i <= last; i++){
                if(i != 2 && i % 2 == 0) continue;
                var num = new BigInteger(i);
                if(IsPrime(num) && GetDigits(num).All(x => IsPrime(x))){
                    megaprimeCount++;
                }
            }

            Console.WriteLine(megaprimeCount);
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var boundary = (long)Math.Floor(Math.Sqrt(number));
            for (long i = 2; i <= boundary; i++)
                if (number % i == 0)  return false;
            
            return true;        
        }

        public static bool IsPrime(BigInteger number){
            if (number == 1) return false;
            if (number == 2) return true;
            var boundary = Sqrt(number);
            for (long i = 2; i <= boundary; i++)
                if (number % i == 0)  return false;
            
            return true; 
        }

        public static BigInteger Sqrt(BigInteger x)
        {
            // this is the next bit we try 
            int b = 15;
            BigInteger r = 0;
            BigInteger r2 = 0;
            while(b >= 0) 
            {
                BigInteger sr2 = r2;
                BigInteger sr = r;
                // compute (r+(1<<b))**2, we have r**2 already.
                r2 += (BigInteger)((r << (1 + b)) + (1 << (b + b)));      
                r += (BigInteger)(1 << b);
                if (r2 > x) 
                {
                    r = sr;
                    r2 = sr2;
                }
                b--;
            }
            return r;
        }
        public static BigInteger Sqrt2(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!IsSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean IsSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = BigInteger.Multiply(root, root);;
            BigInteger upperBound = BigInteger.Multiply(
                BigInteger.Add(root, BigInteger.One), 
                BigInteger.Add(root, BigInteger.One));
            
            return (n >= lowerBound && n < upperBound);
        }

        public static long[] GetDigits(long num)
        {
            List<long> listOfInts = new List<long>();
            while(num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        public static BigInteger[] GetDigits(BigInteger num){
            List<BigInteger> listOfInts = new List<BigInteger>();
            var ten = new BigInteger(10);
            while(num > 0)
            {
                listOfInts.Add(num % ten);
                num = BigInteger.Divide(num, ten);
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
