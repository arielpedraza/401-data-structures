using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableApp
{
    public class HashTable
    {
        private readonly int _tableSize;
        private List<HashSet>[] _hashTable;
        
        public HashTable(int expectedTableSize)
        {
            _tableSize = expectedTableSize;
            _hashTable = new List<HashSet>[expectedTableSize];
            for (int i = 0; i < _hashTable.Length; i++)
            {
                _hashTable[i] = new List<HashSet>();
            }
        }

        public void Add(string key, int value)
        {
            int hash = key.GetHashCode();
            int index = Math.Abs(hash % _tableSize);
            _hashTable[index].Add(new HashSet { Key=key, Value=value });
        }

        public int Get(string key)
        {
            int hash = key.GetHashCode();
            int index = Math.Abs(hash % _tableSize);
            foreach(HashSet x in _hashTable[index])
            {
                if (x.Key == key) return x.Value;
            }
            return int.MinValue;
        }

        public void Print()
        {
            foreach(List<HashSet> list in _hashTable)
            {
                Console.Write("-");
                foreach(HashSet set in list)
                {
                    if(set != null)
                        Console.Write(set.Key + set.Value);
                }
                Console.WriteLine("");
            }
        }
    }
}
