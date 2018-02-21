using System;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HashTable hashTable = new HashTable(10);
            hashTable.Add("Ariel", 10);
            hashTable.Add("Jeff", 20);
            hashTable.Add("Andres", 30);
            hashTable.Add("Dustin", 40);
            hashTable.Add("Luay", 50);
            hashTable.Add("Zach", 60);
            hashTable.Add("Austin", 70);
            hashTable.Add("Amanda", 80);
            hashTable.Add("Joy", 90);
            hashTable.Add("Nicholas", 100);

            hashTable.Print();
            Console.WriteLine(hashTable.Get("Joy"));

            Console.ReadLine();
        }
    }
}
