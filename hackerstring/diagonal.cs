using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           a[a_i] = Console.ReadLine().Trim()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();
        }
        var fwd = 0;
        var bck = 0;
        for (int i = 0; i < n; i++)
        {
            int last = n-1;
          fwd += a[i][i];
          bck += a[last-i][i];
          Console.WriteLine(fwd);
          Console.WriteLine(bck);
        }
        var difference = Math.Abs(fwd - bck);
        Console.WriteLine(difference);

        var s = new StringBuilder();
        
    }
}
