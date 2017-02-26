
namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Migratory Birds");
            int birdCount = Convert.ToInt32(Console.ReadLine());
            if(birdCount < 5 || birdCount > (2*Math.Pow(10, 5))) 
                throw new ArgumentOutOfRangeException("birdcount is invalid");
            
            List<int> birds = Console.ReadLine()
                .Trim().Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToList();
            
            var allowedBirds = new List<int>{1, 2, 3, 4, 5};
            if(birds.Any(x => !allowedBirds.Contains(x)))
                throw new ArgumentException("invalid bird type");
            
            var occurance = birds.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);
            Console.WriteLine(occurance.First().Key);
        }
    }
}
