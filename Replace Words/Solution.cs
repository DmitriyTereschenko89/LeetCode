namespace Replace_Words
{
    internal class Solution
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            string[] words = sentence.Split(' ');
            List<string> replacedWords = [];
            HashSet<string> wordsSet = new(dictionary);
            Trie trie = new();
            for (int i = 0; i < dictionary.Count; ++i)
            {
                trie.Push(dictionary[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                string replacedWord = trie.FindMaxSubstring(words[i]);
                if (wordsSet.Contains(replacedWord))
                {
                    replacedWords.Add(replacedWord);
                    continue;
                }

                replacedWords.Add(words[i]);
            }

            return string.Join(" ", replacedWords);
        }
    }
}
