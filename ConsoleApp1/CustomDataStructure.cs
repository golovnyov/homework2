using System;
using System.Collections;

namespace ConsoleApp1
{
    public class CustomDataStructure
    {
        private Hashtable hashtable;

        private object[] array;

        private Func<int, int> _hash;

        private int _currentIndex;

        private int _sparseness;

        public CustomDataStructure(Func<int, int> hashFunction, int insertionCount, int sparseness)
        {
            _hash = hashFunction;

            hashtable = new Hashtable();

            array = new object[insertionCount];

            _sparseness = sparseness;
        }

        public object this[int i]
        {
            set
            {
                SetValue(i, value);
            }
        }

        private void SetValue(int index, object value)
        {
            _currentIndex = index;

            if ((index -_currentIndex) > _sparseness)
            {
                hashtable.Add(new Key(index, _hash), value);
            }
            else
            {
                array[index] = value;
            }
        }
    }
}
