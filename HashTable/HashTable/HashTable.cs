using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableApp
{
    public class HashTable
    {
        private readonly int _tableSize;
        private List<int>[] _hashTable;
        
        public HashTable(int expectedTableSize)
        {
            _tableSize = expectedTableSize;
            _hashTable = new List<int>[expectedTableSize];
            for (int i = 0; i < _hashTable.Length; i++)
            {
                _hashTable[i] = new List<int>();
            }
        }

        public void Add(string key, int value)
        {
            int hash = key.GetHashCode();
            int index = hash % _tableSize;
            _hashTable[index].Add(value);
        }

        public int Get(string key)
        {
            int hash = key.GetHashCode();
            int index = hash % _tableSize;
            foreach(int i in _hashTable[index])
            {
                if ()
            }
        }
    }
}
