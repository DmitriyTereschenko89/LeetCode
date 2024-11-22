namespace Prime_Subtraction_Operation
{
    internal class Solution
    {
        private List<int> SieveSundaram(int num)
        {
            int k = (num - 1) / 2;
            bool[] sieve = new bool[k + 1];
            List<int> primes = [];
            Array.Fill(sieve, true);
            for (int j = 1; j <= k; ++j)
            {
                int i = j;
                while (i + j + 2 * j * i <= k)
                {
                    sieve[i + j + 2 * j * i] = false;
                    ++i;
                }
            }

            primes.Add(2);
            for (int i = 1; i <= k; ++i)
            {
                if (sieve[i])
                {
                    primes.Add(2 * i + 1);
                }
            }

            return primes;
        }

        private int BinarySearch(List<int> primes, int target)
        {
            int left = 0;
            int right = primes.Count;
            while (right - left > 1)
            {
                int middle = (left + right) / 2;
                if (primes[middle] >= target)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }

            Console.WriteLine(primes[left]);
            return left;
        }

        public bool PrimeSubOperation(int[] nums)
        {
            int n = nums.Length;
            int prevNumber = nums[n - 1];
            List<int> primes = SieveSundaram(1000);
            for (int i = n - 2; i >= 0; --i)
            {
                if (nums[i] >= prevNumber)
                {
                    int closestPrimaryIndex = BinarySearch(primes, nums[i]);
                    nums[i] = nums[i] - (primes[closestPrimaryIndex] == prevNumber ? 0 : primes[closestPrimaryIndex]);
                    //if (nums[i] >= prevNumber)
                    //{
                    //    return false;
                    //}
                }

                prevNumber = nums[i];
            }

            Console.WriteLine(string.Join(", ", nums));
            return true;
        }
    }
}
