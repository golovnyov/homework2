using System;
using System.Collections;

namespace ConsoleApp1
{
    public class CustomDataStructure
    {
        private Hashtable hashtable;

        private object[] array;

        private Func<int, int> _hash;

        public CustomDataStructure(Func<int, int> hashFunction)
        {
            _hash = hashFunction;

            hashtable = new Hashtable();

            //array = new object[1000000];
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
            hashtable.Add(new Key(index, _hash), value);

            //if (index <= 1e6)
            //{
            //    array[index] = value;
            //}
            //else
            //{
            //    hashtable.Add(new Key(index, _hash), value);
            //}
        }
    }
}
