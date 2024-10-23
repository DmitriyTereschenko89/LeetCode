using System;
using System.Collections.Generic;

namespace Number_Complement
{
    internal class Solution
    {
        public int FindComplement(int num)
        {
            //List<int> bits = [];
            //while (num != 0)
            //{
            //    int bit = num & 1;
            //    bits.Add(bit);
            //    num >>= 1;
            //}

            //int n = bits.Count;
            //for (int i = 0; i < n; ++i)
            //{
            //    bits[i] ^= 1;
            //}

            //int res = 0;
            //for (int i = n - 1; i >= 0; --i)
            //{
            //    res += bits[i] * (int)Math.Pow(2, i);
            //}

            //return res;

            int bitsLength = (int)Math.Log(num, 2) + 1;
            int mask = (1 << bitsLength) - 1;
            return num ^ mask;
        }
    }
}
