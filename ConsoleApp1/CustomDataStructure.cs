using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomDataStructure
    {
        private Hashtable hashtable;

        private object[] array;

        public object this[int i]
        {
            set
            {
                SetValue(i, value);
            }
        }

        private void SetValue(int index, object value)
        {

        }
    }
}
