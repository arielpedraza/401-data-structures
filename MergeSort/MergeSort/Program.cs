using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted:");
            int[] array = new int[] { 5, 2, 1, 8, 4, 7, 3 };
            foreach (int i in array) Console.Write(i + " ");
            MergeSort(array);
            Console.WriteLine("\nSorted:");
            foreach (int i in array) Console.Write(i + " ");
            Console.ReadLine();
        }

        static void MergeSort(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;
            MergeSort(array, low, high);
        }

        static void MergeSort(int[] array, int low, int high)
        {
            if (high-low < 1) return;
            int p = (low + high) / 2;
            MergeSort(array, low, p);
            MergeSort(array, p + 1, high);
            HelpMerge(array, low, p, p + 1, high);
        }

        static void HelpMerge(int[] array, int left, int midleft, int midright, int right)
        {
            int i = left;
            int j = midright;
            int k = 0;
            int[] tempArr = new int[right - left + 1];

            while (i <= midleft && j <= right)
            {
                if (array[i] < array[j])
                {
                    tempArr[k] = array[i];
                    i++; k++;
                }
                else
                {
                    tempArr[k] = array[j];
                    j++; k++;
                }
            }

            if(i > midleft)
            {
                for(int x = j; x <= right; x++)
                {
                    tempArr[k] = array[x];
                    k++;
                }
            }
            else
            {
                for (int y = i; y <= midleft; y++)
                {
                    tempArr[k] = array[y];
                    k++;
                }
            }

            Console.Write("\nIn progress sorting:\n");
            foreach(int z in tempArr)
            {
                Console.Write(z + " ");
                array[left] = z;
                left++;
            }
        }
    }
}
