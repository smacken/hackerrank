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
            Console.WriteLine("Programmer day!");

            int y = Convert.ToInt32(Console.ReadLine());
            if (y < 1700 || y > 2700) throw new ArgumentException("y");

            Func<int, bool, bool> isLeapYear = (year, isJulian) => {
                if(isJulian) return year % 4 == 0;
                return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            };
            bool isJulianYear = y < 1917;
            int dop = 256;
            int[] months = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; 
            if(isLeapYear(y, isJulianYear)) months[1] = 29;
            if(y == 1918) months[1] = 16;
            int targetDay = 0;
            int targetMonth = 0;
            int days = 0;
            for (int i = 0; i < months.Length; i++) {
                days += months[i];
                //Console.WriteLine(days);
                int nextMonth = i+1 >= months.Length ? 0 : i+1;
                var next = months[nextMonth];
                if((days + next) > dop){
                    targetMonth = nextMonth + 1;
                    targetDay = dop - days;
                    break;
                }
            }
            Console.WriteLine(string.Format("{0:00}.{1:00}.{2}", targetDay, targetMonth, y));
        }
    }
}
