namespace Find_Kth_Bit_in_Nth_Binary_String
{
    internal class Solution
    {
        private string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            int n = chars.Length;
            for (int i = 0; i < n / 2; ++i)
            {
                (chars[i], chars[n - i - 1]) = (chars[n - i - 1], chars[i]);
            }

            return new string(chars);
        }

        private string Invert(string s)
        {
            char[] bits = s.ToCharArray();
            int n = bits.Length;
            for (int i = 0; i < n; ++i)
            {
                bits[i] = (char)(((bits[i] - '0') ^ 1) + '0');
            }

            return new string(bits);
        }

        public char FindKthBit(int n, int k)
        {
            string prevBits = "0";
            for (int i = 1; i < n; ++i)
            {
                string curBits = prevBits + "1" + Reverse(Invert(prevBits));
                prevBits = curBits;
            }

            return prevBits[k - 1];
        }
    }
}
