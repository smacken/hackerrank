using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        if(n < 1 || n > 10) throw new ArgumentException("n");
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = arr_temp.Select(x => long.Parse(x)).ToArray();
        if(arr.Any(x => x < 0 || x > (int)Math.Pow(10, 10))) throw new ArgumentException("a");
        long sum = arr.Sum();
        Console.WriteLine(sum);
    }
}