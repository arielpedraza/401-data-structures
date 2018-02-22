using System;
using System.Collections.Generic;

namespace RadixSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };
            foreach (int i in array) Console.Write(i + " ");
            RadixSort(array);
            Console.WriteLine("");
            foreach (int i in array) Console.Write(i + " ");
            Console.ReadLine();
        }

        static void RadixSort(int[] arr)
        {
            // find num of digits in largest number
            int max = 0;
            foreach (int num in arr)
            {
                if (max < num) max = num;
            }

            // Create array of lists, and initialize them
            List<int>[] aol = new List<int>[10];
            for (int i = 0; i < aol.Length; i++)
            {
                aol[i] = new List<int>();
            }

            // Radix Sort Logic
            for (int exp = 1; exp < max; exp *= 10)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    aol[(arr[i] / exp) % 10].Add(arr[i]);
                }

                int k = 0;
                foreach(List<int> L in aol)
                {
                    foreach(int I in L)
                    {
                        arr[k] = I;
                        k++;
                    }
                    L.Clear();
                }
            }
        }
    }
}
