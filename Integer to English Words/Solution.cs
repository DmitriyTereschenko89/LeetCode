namespace Integer_to_English_Words
{
    internal class Solution
    {
        private readonly Dictionary<int, string> onesMap = new()
        {
            [1] = "One",
            [2] = "Two",
            [3] = "Three",
            [4] = "Four",
            [5] = "Five",
            [6] = "Six",
            [7] = "Seven",
            [8] = "Eight",
            [9] = "Nine",
            [10] = "Ten",
            [11] = "Eleven",
            [12] = "Twelve",
            [13] = "Thirteen",
            [14] = "Fourteen",
            [15] = "Fifteen",
            [16] = "Sixteen",
            [17] = "Seventeen",
            [18] = "Eighteen",
            [19] = "Nineteen"
        };

        private readonly Dictionary<int, string> tenMaps = new()
        {
            [20] = "Twenty",
            [30] = "Thirty",
            [40] = "Forty",
            [50] = "Fifty",
            [60] = "Sixty",
            [70] = "Seventy",
            [80] = "Eighty",
            [90] = "Ninety"
        };

        private string GetString(int num)
        {
            List<string> parts = [];
            int hundreds = num / 100;
            if (hundreds > 0)
            {
                parts.Add(onesMap[hundreds] + " Hundred");
            }

            int lastPart = num % 100;
            if (lastPart >= 20)
            {
                int tens = lastPart / 10;
                int ones = lastPart % 10;
                if (tens > 0)
                {
                    parts.Add(tenMaps[tens * 10]);
                }

                if (ones > 0)
                {
                    parts.Add(onesMap[ones]);
                }
            }
            else if (lastPart > 0)
            {

                parts.Add(onesMap[lastPart]);
            }

            return string.Join(" ", parts);
        }

        public string NumberToWords(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }

            List<string> words = [];
            string[] postfix = ["", " Thousand", "Million", "Billion"];
            int postfixIdx = 0;
            while (num > 0)
            {
                int digits = num % 1000;
                string sDigits = GetString(digits);
                if (!string.IsNullOrEmpty(sDigits))
                {
                    words.Add(sDigits + postfix[postfixIdx]);
                }

                num /= 1000;
                ++postfixIdx;
            }

            words.Reverse();
            return string.Join(" ", words);
        }
    }
}
