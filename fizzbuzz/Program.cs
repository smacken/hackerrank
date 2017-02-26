using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            
            foreach(int number in Enumerable.Range(1, 100)){
                if(number.IsDivisibleBy(3) && number.IsDivisibleBy(5)){
                    Console.WriteLine("FizzBuzz");
                } else if(number.IsDivisibleBy(3)){
                    Console.WriteLine("Fizz");
                } else if(number.IsDivisibleBy(5)) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(number);
                }
            }
        }
    }

    public static class DivisibleExtensions
    {
        public static bool IsDivisibleBy(this int number, int divisibleBy){
            return number % divisibleBy == 0;
        }

    }
}
