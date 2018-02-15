using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted:");
            int[] array = new int[] { 5, 2, 1, 8, 4, 7, 3 };
            foreach (int i in array) Console.Write(i + " ");
            QuickSort(array, 0, array.Length-1);
            Console.WriteLine("\nSorted:");
            foreach (int i in array) Console.Write(i + " ");
            Console.ReadLine();
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low >= high) return;
            int p = HelpSort(array, low, high);
            QuickSort(array, low, p-1);
            QuickSort(array, p, high);
        }

        static int HelpSort(int[] array, int low, int high)
        {
            int temp;
            while (low <= high)
            {
                int p = (low + high) / 2;
                while (array[low] < array[p]) low++;
                while (array[high] > array[p]) high--;

                if (low <= high)
                {
                    temp = array[low];
                    array[low] = array[high];
                    array[high] = temp;
                    low++; high--;
                }
            }
            Console.Write("\nIn progress sorting:\n");
            foreach (int x in array) Console.Write(x + " ");
            return low;
        }
    }
}
