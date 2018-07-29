namespace BinarySearch
{
    using System.Linq;

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

            var index = 0;
            while (haystack.Length > 1)
            {
                var splittedHaystack = SplitHaystack(haystack);

                var leftHaystack = splittedHaystack.left;
                var rightHaystack = splittedHaystack.right;

                if (needle >= rightHaystack[0])
                {
                    haystack = rightHaystack;
                    index += leftHaystack.Length;
                }
                else if (needle <= leftHaystack[leftHaystack.Length - 1])
                {
                    haystack = leftHaystack;
                }
                else
                {
                    return -1;
                }
            }
            return index;
        }

        private static (int[] left, int[] right) SplitHaystack(int[] haystack)
        {
            var half = haystack.Length / 2;
            return (left: haystack.Take(half).ToArray(), right: haystack.Skip(half).ToArray());
        }
    }
}
