namespace String_Compression_III
{
    using System.Text;

    internal class Solution
    {
        public string CompressedString(string word)
        {
            StringBuilder comp = new();
            int n = word.Length;
            for (int i = 0; i < n; ++i)
            {
                char ch = word[i];
                int cnt = 1;
                while (i < n - 1 && word[i] == word[i + 1])
                {
                    ++i;
                    ++cnt;
                }

                int repeats = cnt / 9;
                for (int j = 0; j < repeats; ++j)
                {
                    comp.Append($"{9}{ch}");
                }

                if (cnt % 9 != 0)
                {
                    comp.Append($"{cnt % 9}{ch}");
                }
            }

            return comp.ToString();
        }
    }
}
