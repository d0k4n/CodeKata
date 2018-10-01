namespace Library.BloomFilter
{
    using System;

    public class MurmurHash3
    {
        public string Hash(string key)
        {

            uint seed = 0;

            uint c1 = 0xcc9e2d51;
            uint c2 = 0x1b873593;
            var r1 = 15;
            var r2 = 13;
            var m = 5;
            uint n = 0xe6546b64;




            return string.Empty;
        }

         public static UInt64 RotateRight(UInt64 x, int n) {
            return (((x) >> (n)) | ((x) << (64-(n))));
        }

        public static UInt64 RotateLeft(UInt64 x, int n) {
            return (((x) << (n)) | ((x) >> (64-(n))));
        }
    }
}
