using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public class HackerRequest
        {
            public int Query { get; set; }
            public string[] Sequence { get; set; }

            public int GetQuery(Func<string> console){
                int q = default(int);
                bool result = int.TryParse(console(), out q);
                if(!result || (q < 2) || (q > (int)Math.Pow(19, 2)))
                    throw new ArgumentException("q");

                return q;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hacker String");
            var req = new HackerRequest();
            //req.Query = req.GetQuery(Console.ReadLine);
            int q = Convert.ToInt32(Console.ReadLine());

            if(q < 2 || q > (int)Math.Pow(19, 2))
                throw new ArgumentException("q");
        
            var input = new string[q];
            for (int i = 0; i < q; i++)
                input[i] = Console.ReadLine();

            for(int query = 0; query < q; query++){
                bool result = HasHackString(input[query]);
                Console.WriteLine(result ? "YES" : "NO");
            }
        }

        public static bool HasHackString(string s){
            if(s.Length < 10 || s.Length > (int)Math.Pow(10, 4))
                return false;
            
            int previousIndex = -1;
            var rank = "hackerrank".ToCharArray();
            int correct = 0;
            for(int i = 0; i < rank.Length; i++)
            {
                var idx = s.IndexOf(rank[i], previousIndex == -1 ? 0 : previousIndex + 1);
                if(idx > previousIndex){
                    previousIndex = idx;
                    correct++;
                    //Console.WriteLine(correct + ": " + rank[i] + ": " + idx);
                }
            }
            //Console.WriteLine(correct);
            return (correct == rank.Length);
        }
    }
}
