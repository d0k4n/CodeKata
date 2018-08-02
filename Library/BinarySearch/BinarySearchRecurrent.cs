namespace Library.BinarySearch
{
    public class BinarySearchRecurrent : IBinarySearch
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

            var lowIndex = 0;
            var highIndex = haystack.Length - 1;

            return recurrentBinarySearch(needle, haystack, lowIndex, highIndex);
        }

        private int recurrentBinarySearch(int needle, int[] haystack, int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex || highIndex < 0)
            {
                return -1;
            }

            var midIndex = (lowIndex + highIndex) / 2;

            if (haystack[midIndex] == needle)
            {
                return midIndex;
            }

            if (needle > haystack[midIndex])
            {
                return recurrentBinarySearch(needle, haystack, midIndex + 1, highIndex);
            } 

            return recurrentBinarySearch(needle, haystack, lowIndex, midIndex - 1);
        }
    }
}
