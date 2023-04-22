namespace Array
{
    public class Array
    {
        private Object[]? _InnerArray;
        private int index = 0;
        public int Count => _InnerArray.Length;
        public Array()
        {
            _InnerArray = new object[4];
        }
        public void Add(Object item)
        {
            _InnerArray[index] = item;
            index++;
        }

    }
}