using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        var dt = DateTime.Parse(time);
        Console.WriteLine(dt.ToString("HH:mm:ss"));
    }
}
