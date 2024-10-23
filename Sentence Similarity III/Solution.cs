namespace Sentence_Similarity_III
{
    internal class Solution
    {
        public bool AreSentencesSimilar(string sentence1, string sentence2)
        {
            string[] words1 = sentence1.Split(' ');
            string[] words2 = sentence2.Split(' ');
            int start = 0;
            int end1 = words1.Length - 1;
            int end2 = words2.Length - 1;
            if (words1.Length > words2.Length)
            {
                return AreSentencesSimilar(sentence2, sentence1);
            }

            
            while (start < words1.Length && words1[start] == words2[start])
            {
                ++start;
            }

            while (end1 >= 0 && words1[end1] == words2[end2])
            {
                --end1;
                --end2;
            }

            return end1 < start;
        }
    }
}
