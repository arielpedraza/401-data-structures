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
        }


    }
}
