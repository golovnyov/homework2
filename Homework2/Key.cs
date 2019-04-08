using System;

namespace Homework2
{
    public class Key
    {
        private int _hash;

        public Key(int index, Func<int, int> hashFuncton)
        {
            if (hashFuncton == null)
            {
                throw new ArgumentNullException(nameof(hashFuncton));
            }

            _hash = hashFuncton(index);
        }

        public override int GetHashCode()
        {
            return _hash;
        }
    }
}
