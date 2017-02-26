using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = Console.ReadLine();
            if(s.Length > 100) s.Substring(0, 100);
            string adjacent = @"(.)\1";
            Regex rgx = new Regex(adjacent);
            while(rgx.IsMatch(s)){
                s = rgx.Replace(s, string.Empty);
            }
            Console.WriteLine(s.Length > 0 ? s : "Empty String");
        }

        public static bool IsPanagram(string text){
            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            return text.All(x => letters.Contains(x));
        }

        public static string RemoveDuplicates(List<char> letters){
            char previous = default(char);
            for (int i = 0; i < letters.Count; i++)
            {
                if(letters[i] == previous){
                    letters.RemoveRange(i-1, 2);
                    //RemoveDuplicates(letters);
                }
            }
            return string.Concat(letters);
        }
    }
}
