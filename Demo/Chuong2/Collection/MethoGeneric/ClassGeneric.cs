using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethoGeneric
{
    class ClassGeneric<T>
    {
         private T[] _array;
        public ClassGeneric(int size)
        {
            _array = new T[size + 1];
        }

        public T getItem(int index)
        {
            return _array[index];
        }

        public void setItem(int index, T value)
        {
            _array[index] = value;
        }
    }
}
