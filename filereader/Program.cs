using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("File reader");
            var directory = @"c:\dev\py";
            if(Directory.Exists(directory)){
                foreach (var file in Directory.GetFiles(directory)){
                    Console.WriteLine(file.ToLower());
                    var content = File.ReadLines(file);
                    foreach (var line in content){
                        Console.WriteLine(line.Length);
                    }
                    
                }
            }
        }
    }
}
