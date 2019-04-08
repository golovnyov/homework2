using System;
using System.Collections.Generic;

namespace Homework2
{
    public class CustomDataStructure
    {
        private Dictionary<Key, object> dictionary;

        private object[] array;

        private Func<int, int> _hash;

        public CustomDataStructure(int insertionCount)
        {
            array = new object[insertionCount];
        }

        public CustomDataStructure(Func<int, int> hashFunction)
        {
            _hash = hashFunction;

            dictionary = new Dictionary<Key, object>();
        }

        public object this[int i]
        {
            set
            {
                array[i] = value;
            }
        }

        public void SetHashTableValue(int index)
        {
            dictionary.Add(new Key(index, _hash), index);
        }
    }
}
