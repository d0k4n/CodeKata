namespace Library.BinarySearch
{

    public class BinarySearch : IBinarySearch
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
            
            while (lowIndex <= highIndex)
            {
                var midIndex = (lowIndex + highIndex) / 2;
                if (needle < haystack[midIndex])
                {
                    highIndex = midIndex - 1;
                } 
                else if (needle > haystack[midIndex])
                {
                    lowIndex = midIndex + 1;
                }
                else
                {
                    return midIndex;
                }
            }
            return -1;
        }


    }
}
