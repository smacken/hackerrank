using System;
using System.Linq;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insertion sort");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            if(s < 1 || s > 1000) throw new ArgumentException("s");
            
            insertionSort(arr);
        }

        public void leftRotate()
        {
            for(int i = 0; i < d; i++){
                int[] temp = new int[n];
                for(int j = 0;j < n; j++){
                    if(j-1 < 0){
                        temp[n-1] = arr[j];  
                    } else {
                        temp[j-1] = arr[j];
                    }
                }
                arr = temp;
            }

        }

        public static void insertionSort(int[] ar) {
            int n = ar.Length;
            int x = ar[n-1];
            int j = n-2;
            while(j > 0 && ar[j] >= x){
                ar[j] = ar[j-1];
                j = j-1;
                Console.WriteLine(string.Concat(ar.Select(a => a.ToString() + " ")));
            }
            
            ar[j+1] = x;
            Console.WriteLine(string.Concat(ar.Select(a => a.ToString() + " ")));
            
            // for (int i = 1; i <= n; i++)
            // {
                
            // }
        }
    }
}
