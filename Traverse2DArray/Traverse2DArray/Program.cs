using System;

namespace Traverse2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Traverse(2, 2));
            Console.WriteLine(Traverse(2, 5));
            Console.WriteLine(Traverse(3, 3));
            Console.ReadLine();
        }

        static int Traverse(int m, int n)
        {
            if (m == 1 || n == 1) return 1;
            return Traverse(m - 1, n) + Traverse(m, n - 1);
        }
    }
}
