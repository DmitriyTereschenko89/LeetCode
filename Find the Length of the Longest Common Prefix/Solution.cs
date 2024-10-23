namespace Find_the_Length_of_the_Longest_Common_Prefix
{
    internal class Solution
    {
        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            Trie trie = new();
            foreach (int num in arr1)
            {
                trie.Push(num);
            }

            int maxCommonPrefix = 0;
            foreach (int num in arr2)
            {
                maxCommonPrefix = Math.Max(maxCommonPrefix, trie.GetPrefix(num));
            }

            return maxCommonPrefix;
        }
    }
}
