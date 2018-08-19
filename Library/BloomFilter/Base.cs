namespace Library.BloomFilter
{
    class Base
    {
        private bool[] _filter;

        public Base()
        {
            _filter = new bool[10];
        }


        public void  Add(string value)
        {
            var position = getHash(value);
            _filter[position] = true;
        }

        public bool HasValue(string value)
        {
            var position = getHash(value);
            return _filter[position];
        }


        private int getHash(string value)
        {
            return 0;
        }

        
    }
}
