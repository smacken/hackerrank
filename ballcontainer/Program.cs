using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isPossible = false;

            int queryCount = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < queryCount; a0++){
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] matrix = new int[n][];
                for(int M_i = 0; M_i < n; M_i++){
                    string[] M_temp = Console.ReadLine().Split(' ');
                    matrix[M_i] = M_temp.Select(x => Int32.Parse(x)).ToArray();
                }
                isPossible = CanMatrixRearrange(matrix);
            }

            Console.WriteLine(isPossible ? "Possible" : "Impossible");
        }

        public bool CanMatrixRearrange(int[][] matrix){
            bool isPossible = false;
            foreach (var container in matrix)
            {
                
                foreach (var type in container)
                {
                    
                }    
            }
            return isPossible;
        }

    }
}