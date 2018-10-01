namespace LibraryTest
{

    using Library.BloomFilter;
    using NUnit.Framework;
    
    [TestFixture]
    public class MurmurHash3Test
    {

        //Murmur (Ver 3) - 128-bit - key of Zero - four byte long of 0 value

        [TestCase("Test1", "c2a3056c5b5f012b1b4689af945f0117") ]
        [TestCase("github", "4c4462c42dc86da0ecac78d742855563") ]
        [TestCase("protrip", "4e288d17bc05bb014a5a0e359c432183") ]
        [TestCase("NoNotReallyNo", "a068b629d263732e2bf4c1157b8e43d7") ]
        public void Given_Key_When_Using_Murmur3_Then_Got_Expected_Result(string key, string expectedResult)
        {
            var murmur3 = new MurmurHash3();
            var hash = murmur3.Hash(key);

            Assert.That(hash, Is.EqualTo(expectedResult));
        }

    }
}
