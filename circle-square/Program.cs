using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Circle Square");

            string[] tokens_w = Console.ReadLine().Split(' ');
            int w = Convert.ToInt32(tokens_w[0]);
            int h = Convert.ToInt32(tokens_w[1]);
            string[] tokens_circleX = Console.ReadLine().Split(' ');
            int circleX = Convert.ToInt32(tokens_circleX[0]);
            int circleY = Convert.ToInt32(tokens_circleX[1]);
            int r = Convert.ToInt32(tokens_circleX[2]);
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int y1 = Convert.ToInt32(tokens_x1[1]);
            int x3 = Convert.ToInt32(tokens_x1[2]);
            int y3 = Convert.ToInt32(tokens_x1[3]);
        }
    }
}
