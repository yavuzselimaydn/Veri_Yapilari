using System.Collections;
using System.Net.Http.Headers;

namespace Array
{
    public class Array :IEnumerable
    {
        private Object[]? _InnerArray;
        private int index = 0;
        public int Count => index;
        public int Capacity => _InnerArray.Length;
        public Array()
        {
            _InnerArray = new object[4];
        }
        public void Add(Object item)
        {
            if(index == _InnerArray.Length)
            {
                DoubleArray(_InnerArray);
            }

            _InnerArray[index] = item;
            index++;
        }

        private void DoubleArray(object[] array)
        {
            var newArray = new Object[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray = newArray;
        }

        public int Find(Object item)
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (item.Equals(_InnerArray[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public Object GetItem(int position)
        {
            return _InnerArray[position];
        }

        //array içinde foreach ile dolaşmamı sağlar
        public IEnumerator GetEnumerator()
        {
            return _InnerArray.GetEnumerator();
        }
    }
}