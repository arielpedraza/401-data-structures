using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 3, 8, 2, 1, 9, 4, 6, 7 };
            Console.WriteLine("Before HeapSort:");
            Print(array);
            Console.WriteLine("\n\nDuring HeapSort:");
            HeapSort(array);
            Console.WriteLine("\nAfter HeapSort:");
            Print(array);
            Console.ReadLine();
        }

        static void HeapSort(int[] array)
        {
            BuildMaxHeap(array);
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Print(array);
                Swap(array, 0, i);
                Heapify(array, 0);
                Console.WriteLine("");
            }
        }

        static void BuildMaxHeap(int[] array)
        {
            for (int i = (array.Length-2)/2; i >= 0; i--)
            {
                Heapify(array, i);
            }
        }

        static void Heapify(int[] array, int i)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int max = i;

            if (left < array.Length && array[left] > array[i])
            {
                max = left;
            }
            if (right < array.Length && array[right] > array[max])
            {
                max = right;
            }

            if (max != i)
            {
                Swap(array, i, max);
                Heapify(array, max);
            }
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        static void Print(int[] array)
        {
            foreach (int i in array) Console.Write(i);
        }
    }
}
