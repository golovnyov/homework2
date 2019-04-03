using System;

namespace ConsoleApp1
{
    public class Key
    {
        private Func<int> _hashFunction;

        public Key(Func<int> hashFuncton)
        {
            _hashFunction = hashFuncton;
        }

        public override int GetHashCode()
        {
            return _hashFunction();
        }
    }
}
