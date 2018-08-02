namespace Library.BinarySearch
{
    using System.Linq;

    public class BinarySearchRecurrentWithArrayChop : IBinarySearch
    {
        public int Search(int needle, int[] haystack)
        {
            if (haystack == null 
                || haystack.Length == 0 
                || needle < haystack[0] 
                || needle > haystack[haystack.Length - 1])
            {
                return -1;
            }

            return recurrentBinarySearch(needle, haystack, 0);
        }

        private int recurrentBinarySearch(int needle, int[] haystack, int offset)
        {

            var midIndex = haystack.Length / 2;

            if (haystack[midIndex] == needle)
            {
                return midIndex + offset;
            }

            if (haystack.Length <= 1)
            {
                return -1;
            }

            if (needle > haystack[midIndex])
            {
                return recurrentBinarySearch(needle, haystack.Skip(midIndex).ToArray(), offset + midIndex);
            } 

            return recurrentBinarySearch(needle, haystack.Take(midIndex).ToArray(), offset);
        }
    }
}
