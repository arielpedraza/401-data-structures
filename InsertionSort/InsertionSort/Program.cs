using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted:");
            int[] array = new int[] { 5, 2, 1, 8, 4 };
            foreach (int i in array) Console.Write(i + " ");
            int[] sorted = InsertionSort(array);
            Console.WriteLine("\nSorted:");
            foreach (int i in sorted) Console.Write(i + " ");
            Console.ReadLine();
        }

        static int[] InsertionSort(int[] array)
        {
            Console.Write("\nIn progress sorting:");
            int[] myArray = array;
            int temp;
            for (int i = 0; i < myArray.Length-1; i++)
            {
                for (int k = i; k >= 0; k--)
                {
                    if (myArray[k] > myArray[k + 1])
                    {
                        temp = myArray[k];
                        myArray[k] = myArray[k + 1];
                        myArray[k + 1] = temp;
                    }
                    else break;
                }
                Console.WriteLine();
                foreach (int x in myArray) Console.Write(x + " ");
            }
            return myArray;
        }
    }
}
