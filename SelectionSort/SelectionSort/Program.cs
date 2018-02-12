using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted:");
            int[] array = new int[] {5,2,7,8,4};
            foreach (int i in array) Console.Write(i + " ");
            int[] sorted = SelectionSort(array);
            Console.WriteLine("\nSorted:");
            foreach (int i in sorted) Console.Write(i + " ");
            Console.ReadLine();
        }

        static int[] SelectionSort(int[] array)
        {
            int[] myArray = array;
            int temp, bucket;
            for (int i = 0; i < myArray.Length; i++)
            {
                temp = i;
                for (int k = i+1; k < myArray.Length; k++)
                {
                    if (myArray[temp] > myArray[k]) temp = k;
                }
                if(myArray[temp] < myArray[i])
                {
                    bucket = myArray[i];
                    myArray[i] = myArray[temp];
                    myArray[temp] = bucket;
                }
            }
            return myArray;
        }
    }
}
