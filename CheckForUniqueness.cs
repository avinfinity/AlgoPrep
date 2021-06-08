namespace AlgoPrep
{
    public class UniquenessCheck
    {
        public static void Verify()
        {
            Assert.IsTrue(isUnique("abcdefg"));
            Assert.IsFalse(isUnique("abccd"));
            Assert.IsTrue(isUnique("a"));
            Assert.IsTrue(isUnique("ab"));
            Assert.IsFalse(isUnique("aabbccddeeff"));
            Assert.IsFalse(isUnique(null));
            Assert.IsFalse(isUnique(""));
            Assert.IsFalse(isUnique(" "));


            Assert.IsTrue(isUniqueOptimized("abcdefg"));
            Assert.IsFalse(isUniqueOptimized("abccd"));
            Assert.IsTrue(isUniqueOptimized("a"));
            Assert.IsTrue(isUniqueOptimized("ab"));
            Assert.IsFalse(isUniqueOptimized("aabbccddeeff"));
            Assert.IsFalse(isUniqueOptimized(null));
            Assert.IsFalse(isUniqueOptimized(""));
            Assert.IsFalse(isUniqueOptimized(" "));
        }

        //Brute force - O(n^2)
        static bool isUnique(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input.Length < 1)
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

//O(n) complexity but space is not optimized
//assumes that input would be only in ascii chars
        static bool isUniqueOptimized(string input)
        {
            if (string.IsNullOrEmpty(input) || 
                string.IsNullOrWhiteSpace(input) || 
                input.Length < 1)
                {
                    return false;
                }
                    
            bool[] bits = new bool[256];

            for (int i = 0; i < input.Length; i++)
            {
                if(bits[(byte)input[i]])
                {
                    return false;
                }
                bits[(byte)input[i]] = true;
            }
            return true;
        }
    }

}
