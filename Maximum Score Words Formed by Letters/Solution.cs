namespace Maximum_Score_Words_Formed_by_Letters
{
    internal class Solution
    {
        private const int LetterSize = 26;
        private int maxScoreWord = 0;
        private int[] freqs;
        private int[] subsetFreqs;
        private bool IsCanCreate(int[] freqs, int[] candidate)
        {
            for (int i = 0; i < LetterSize; ++i)
            {
                if (freqs[i] < candidate[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void MaxScoreWordsHelper(int index, string[] words, int[] score, int totalScore)
        {
            if (index == -1)
            {
                maxScoreWord = Math.Max(maxScoreWord, totalScore);
                return;
            }
            MaxScoreWordsHelper(index - 1, words, score, totalScore);
            foreach (char c in words[index])
            {
                ++subsetFreqs[c - 'a'];
                totalScore += score[c - 'a'];
            }

            if (IsCanCreate(freqs, subsetFreqs))
            {
                MaxScoreWordsHelper(index - 1, words, score, totalScore);
            }

            foreach (char c in words[index])
            {
                --subsetFreqs[c - 'a'];
                totalScore -= score[c - 'a'];
            }
        }

        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            maxScoreWord = 0;
            freqs = new int[LetterSize];
            subsetFreqs = new int[LetterSize];
            foreach (char c in letters)
            {
                ++freqs[c - 'a'];
            }

            MaxScoreWordsHelper(words.Length - 1, words, score, 0);
            return maxScoreWord;            
        }
    }
}
