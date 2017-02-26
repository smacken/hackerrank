using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sequence Equation");
            var elementCountText = Console.ReadLine();
            int elementCount;
            bool parseCount = int.TryParse(elementCountText, out elementCount);
            if(!parseCount || elementCount <= 0) return;
            if(elementCount > 50) elementCount = 50;
            var sequence = Console.ReadLine()
                .Trim().Split(' ')
                .Select(x => int.Parse(x)
                ).ToArray();
            
            Console.WriteLine("\nOutput");
            var usedElement = new int[elementCount];
            for (int i = 0; i < (elementCount); i++){
                var y = sequence[i];
                var x = y;
                if(!usedElement.Contains(x)){
                    usedElement[i] = x;
                    Console.WriteLine(x);
                }
            }
        }
    }
}
