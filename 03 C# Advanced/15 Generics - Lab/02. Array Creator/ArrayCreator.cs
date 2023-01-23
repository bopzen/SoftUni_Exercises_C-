using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] internalArray = new T[length];
            for (int i = 0; i < internalArray.Length; i++)
            {
                internalArray[i] = item;
            }
            return internalArray;
        }
    }
}
